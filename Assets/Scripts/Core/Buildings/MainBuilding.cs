using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using Core.CommandExecutors;
using System.Threading.Tasks;
using UnityEngine;

public sealed class MainBuilding : MonoBehaviour, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Transform PivotPoint => _pivotPoint;

    public Vector3 RallyPoint { get; set; }
   
    [SerializeField] private Transform _pivotPoint;

    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;

    private float _health = 1000;   

   
}