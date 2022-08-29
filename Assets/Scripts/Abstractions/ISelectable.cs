using UnityEngine;
using UnityEngine.UI;

namespace Abstractions
{
    public interface ISelectable
    {
        float Health { get; }
        float MaxHealth { get; }
        Sprite Icon { get; }
        Outline Outline { get; }
    }
}