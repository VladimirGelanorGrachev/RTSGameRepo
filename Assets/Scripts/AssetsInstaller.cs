using Abstractions;
using System;
using UnityEngine;
using UserControlSystem;
using Utils;
using Zenject;

[CreateAssetMenu(fileName = "AssetsInstaller", menuName = "Installers/AssetsInstaller")]
public class AssetsInstaller : ScriptableObjectInstaller<AssetsInstaller>
{
    [SerializeField] private AssetsContext _assetsContext;
    [SerializeField] private Vector3Value _groundClicksRMB;
    [SerializeField] private AttackableValue _attackableClicksRMB;
    [SerializeField] private SelectableValue _selectables;
    [SerializeField] private IGameStatus _gameStatus;


    public override void InstallBindings()
    {
        Container.Bind<IAwaitable<IAttackable>>()
           .FromInstance(_attackableClicksRMB);
        Container.Bind<IAwaitable<Vector3>>()
            .FromInstance(_groundClicksRMB);        
        Container.Bind<IObservable<ISelectable>>().FromInstance(_selectables);
        Container.BindInstances(_assetsContext, _selectables);
        Container.Bind<IGameStatus>().FromInstance(_gameStatus);
    }
}