using Abstractions;

public interface IUnitUpradeTask : IIconHolder
{
    public string UnitName { get; }
    public float TimeLeft { get; }
    public float ProductionTime { get; }
}