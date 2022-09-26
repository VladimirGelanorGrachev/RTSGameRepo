using Abstractions;
using System.Text;
using TMPro;
using UniRx;
using UnityEngine;
using Zenject;



public class GameOverScreenPresenter : MonoBehaviour
{
    [Inject] private IGameStatus _gameStatus;

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject _view;

    [Inject]
    private void Init()
    {
        _gameStatus.Status.ObserveOnMainThread().Subscribe(result =>
        {
            var sb = new StringBuilder($"Game Over!");
            if (result == 0)
            {
                sb.AppendLine("Ничья!");
            }
            else
            {
                sb.AppendLine($"Победа за №{result}");
            }
            _view.SetActive(true);
            _text.text = sb.ToString();
            Time.timeScale = 0;
        });
    }
}



