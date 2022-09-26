using Abstractions;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameStatus), menuName = "Strategy Game/"+nameof(GameStatus), order = 0)]
public sealed class GameStatus : StatelessScriptableObjectValueBase<IGameStatus>
{

}
   

