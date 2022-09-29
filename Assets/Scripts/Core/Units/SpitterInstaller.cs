using Abstractions;
using Abstractions.Commands;
using Core;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Abstractions
{
    public class SpitterInstaller : MonoInstaller
    {
        [SerializeField] private AttackerParallelnfoUpdater _attackerParallelnfoUpdater;
        [SerializeField] private FactionMemberParallelInfoUpdater _factionMemberParallelInfoUpdater;

        public override void InstallBindings()
        {
            Container.Bind<IHealthHolder>().FromComponentInChildren();
            Container.Bind<float>().WithId("AttackingDistance").FromInstance(5f);
            Container.Bind<int>().WithId("AttackingPeriod").FromInstance(1400);

            Container.Bind<IAutomaticAttacker>().FromComponentInChildren();
            Container
                .Bind<ITickable>()
                .FromInstance(_attackerParallelnfoUpdater);
            Container
                .Bind<ITickable>()
                .FromInstance(_factionMemberParallelInfoUpdater);
            Container.Bind<IFactionMember>().FromComponentInChildren();
            Container.Bind<ICommandsQueue>().FromComponentInChildren();
        }
    }
}
