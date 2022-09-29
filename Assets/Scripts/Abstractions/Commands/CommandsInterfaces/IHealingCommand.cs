using Abstractions;
using Abstractions.Commands;

public interface IHealingCommand : ICommand
{
   public IHealable Target { get; }
}
