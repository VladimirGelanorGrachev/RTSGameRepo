using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Zenject;

namespace Core
{
    public class UpgradeBuildingCommandQueque : MonoBehaviour, ICommandsQueue
    {
        public ICommand CurrentCommand => default;

        [Inject] CommandExecutorBase<IUpgradeUnitCommand> _upgradeUnitCommandExecutor;

        public void Clear() { }

        public async void EnqueueCommand(object command)
        {
            await _upgradeUnitCommandExecutor.TryExecuteCommand(command);
        }
    }
}
