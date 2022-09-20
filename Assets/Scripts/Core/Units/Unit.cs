using Abstractions;
using Core.CommandExecutors;
using UnityEngine;

namespace Core
{
    public class Unit : MonoBehaviour, ISelectable, IAttackable, IUnit, IDamageDeal
    {
        public float Health => _health;

        public float MaxHealth => _maxHealth;

        public Sprite Icon => _icon;

        public Transform PivotPoint => _pivotPoint;

        public int Damage => _damage;

        [SerializeField] private Sprite _icon;
        [SerializeField] private Animator _animator;
        [SerializeField] private StopCommandExecutor _stopCommand;
        [SerializeField] private Transform _pivotPoint;
        [SerializeField] private float _maxHealth = 25;
        [SerializeField] private int _damage = 5;

        private float _health = 25;

        public void ReceiveDamage(int amount)
        {
            if (_health <= 0)
            {
                return;
            }
            _health -= amount;
            if (_health <= 0)
            {
                _animator.SetTrigger("PlayDead");
                Invoke(nameof(Destroy), 1f);
            }
        }
        private async void Destroy()
        {
            await _stopCommand.ExecuteSpecificCommand(new StopCommand());
            Destroy(gameObject);
        }
    }
}      
