using Abstractions.Commands.CommandsInterfaces;

namespace UserControlSystem
{ 
    public sealed class AttackCommandCreator : CancellableCommandCreatorBase<IAttackCommand, IAttackable>
    {
        protected override IAttackCommand CreateCommand(IAttackable argument) => new AttackCommand(argument);
    }
}