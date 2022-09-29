using Abstractions;

public class HealingCommand : IHealingCommand
{
    public IHealable Target { get; }
    public HealingCommand(IHealable target) => Target = target;
}
    
