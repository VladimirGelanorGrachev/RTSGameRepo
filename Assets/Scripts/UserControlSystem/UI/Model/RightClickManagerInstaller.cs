using UserControlSystem;
using Zenject;

public class RightClickManagerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<RightClickManager>().AsSingle();
    }
}
