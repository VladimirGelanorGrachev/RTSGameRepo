namespace Abstractions
{
    public interface IHealable : IHealthHolder
    {
        void ReceiveDamage(int amount);
    }
}