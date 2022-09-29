using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Threading.Tasks;

namespace UserControlSystem
{
    public class UpgradeUnitCommandExecutor : CommandExecutorBase<IUpgradeUnitCommand>
    {
        public override async Task ExecuteSpecificCommand(IUpgradeUnitCommand command)
        {
            var upgradeBuilding = GetComponent<UpgradeBuilding>();            
        }
    }
}
