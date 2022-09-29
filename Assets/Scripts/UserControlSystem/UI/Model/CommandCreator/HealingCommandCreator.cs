using Abstractions;
using UserControlSystem;

public sealed class HealingCommandCreator : CancellableCommandCreatorBase<IHealingCommand, IHealable>
{
    protected override IHealingCommand CreateCommand(IHealable argument) => new HealingCommand(argument);
}
