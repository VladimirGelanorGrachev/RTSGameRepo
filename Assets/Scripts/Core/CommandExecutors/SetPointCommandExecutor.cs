using System.Threading.Tasks;
using Abstractions;

namespace Core.CommandExecutors
{
    public class SetPointCommandExecutor : CommandExecutorBase<ISetRallyPointCommand>
    {
        public override Task ExecuteSpecificCommand(ISetRallyPointCommand command)
        {
            GetComponent<MainBuilding>().RallyPoint = command.RallyPoint;
            return Task.CompletedTask;
        }
    }
}