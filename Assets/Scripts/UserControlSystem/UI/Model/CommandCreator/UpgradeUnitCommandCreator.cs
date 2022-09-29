using Abstractions.Commands.CommandsInterfaces;
using System;
using Utils;
using Zenject;

namespace UserControlSystem
{
    public sealed class UpgradeUnitCommandCreator : CommandCreatorBase<IUpgradeUnitCommand>
    {
        [Inject] private AssetsContext _context;
        [Inject] private DiContainer _diContainer;

        protected override void ClassSpecificCommandCreation(Action<IUpgradeUnitCommand> creationCallback)
        {
            var upgradeUnitCommand = _context.Inject(new UpgradeUnitCreatorHeir());
            _diContainer.Inject(upgradeUnitCommand);
            creationCallback?.Invoke(upgradeUnitCommand);
        }
    }
}
