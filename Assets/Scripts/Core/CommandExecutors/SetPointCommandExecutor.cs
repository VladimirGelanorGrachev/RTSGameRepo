using System.Threading.Tasks;
using Abstractions;
using Abstractions.Commands;

namespace Core.CommandExecutors
{
    public class SetPointCommandExecutor : CommandExecutorBase<ISetRallyPointCommand>
    {
        public override async Task ExecuteSpecificCommand(ISetRallyPointCommand command)
        {
            GetComponent<MainBuilding>().RallyPoint = command.RallyPoint;            
        }
    }
}