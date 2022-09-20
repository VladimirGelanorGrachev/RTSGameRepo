using Abstractions.Commands.CommandsInterfaces;
using System.Threading.Tasks;

namespace Abstractions.Commands
{
    public interface ICommandExecutor
    { 

    }
    public interface ICommandExecutor<T> : ICommandExecutor where T : ICommand
    {       
        Task ExecuteSpecificCommand(T command);
    }
}
