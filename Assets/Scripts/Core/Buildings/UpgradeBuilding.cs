using Abstractions;
using UnityEngine;

public sealed class UpgradeBuilding : MonoBehaviour, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Transform PivotPoint => _pivotPoint;

    public Vector3 RallyPoint { get; set; }

    
    [SerializeField] private float _maxHealth = 500;
    [SerializeField] private Sprite _icon;

    private float _health = 500;
    private Transform _pivotPoint;
}
