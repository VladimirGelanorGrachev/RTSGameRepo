using UnityEngine;

namespace Abstractions.Commands.CommandsInterfaces
{
    public interface IUpgradeUnitCommand : ICommand, IIconHolder
    {
        float UpgradeTime { get; }
        string UnitName { get; }
        Sprite IconArmor { get; }
        Sprite IconWeapon { get; }

    }
}
