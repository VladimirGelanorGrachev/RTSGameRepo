using UniRx;

public interface IUnitUpgrade 
{
    IReadOnlyReactiveCollection<IUnitUpradeTask> Queue { get; }
    public void Cancel(int index);

}
