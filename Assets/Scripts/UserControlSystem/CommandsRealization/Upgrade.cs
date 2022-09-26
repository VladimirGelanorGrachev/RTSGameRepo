using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Zenject;

namespace UserControlSystem.CommandsRealization
{
    public class Upgrade : IUpgradeUnitCommand
    {               
        [Inject(Id = "Chomper")] public string UnitName { get; }
        [Inject(Id = "Chomper")] public Sprite Icon { get; }
        [Inject(Id = "Chomper")] public float UpgradeTime { get; }
        [Inject(Id = "sword")] public Sprite IconWeapon { get; }
        [Inject(Id = "bronze_coin")] public Sprite IconArmor { get; }

    }
}
