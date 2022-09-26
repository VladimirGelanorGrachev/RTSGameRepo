using System.Linq;
using Abstractions;
using UnityEngine;
using UnityEngine.EventSystems;
using UserControlSystem;
using Zenject;
using UniRx;

public class MouseInteractionPresenter : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SelectableValue _selectedObject;
    [SerializeField] private EventSystem _eventSystem;

    [SerializeField] private Vector3Value _groundClicksRMB;
    [SerializeField] private AttackableValue _attackablesRMB;
    [SerializeField] private Transform _groundTransform;

    private Plane _groundPlane;

    [Inject]
    private void Init()
    {
        _groundPlane = new Plane(_groundTransform.up, 0);

        var FrameStream = Observable.EveryUpdate()
            .Where(_ => !_eventSystem.IsPointerOverGameObject());

        var leftClickStream = FrameStream.Where(_ => Input.GetMouseButtonDown(0));
        var rightClickStream = FrameStream.Where(_ => Input.GetMouseButtonDown(1));

        var lmbRays = leftClickStream.Select(_ => _camera.ScreenPointToRay(Input.mousePosition));
        var rmbRays = rightClickStream.Select(_ => _camera.ScreenPointToRay(Input.mousePosition));

        var lmbHitStream = lmbRays.Select(ray => Physics.RaycastAll(ray));
        var rmbHitStream = rmbRays.Select(ray => (ray, Physics.RaycastAll(ray)));

        lmbHitStream.Subscribe(hits =>
        {
            if (WeHit<ISelectable>(hits, out var selectable))
            {
                _selectedObject.SetValue(selectable);
            }
        });

        rmbHitStream.Subscribe((ray, hits) =>
        {
            if (WeHit<IAttackable>(hits, out var attackable))
            {
                _attackablesRMB.SetValue(attackable);
            }
            else if (_groundPlane.Raycast(ray, out var enter))
            {
                _groundClicksRMB.SetValue(ray.origin + ray.direction * enter);
            }
        });
    }

    private bool WeHit<T>(RaycastHit[] hits, out T result) where T : class
    {
        result = default;
        if (hits.Length == 0)
            return false;

        result = hits.Select(hits => hits.collider.GetComponentInParent<T>()).FirstOrDefault(c => c != null);

        return result != default;
    }
}