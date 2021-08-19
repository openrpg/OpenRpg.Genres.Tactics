using System.Numerics;
using OpenRpg.Combat.Effects;
using OpenRpg.Core.Stats;
using OpenRpg.Tactics.Abilities;

namespace OpenRpg.Tactics.Units
{
    public interface IUnit : IHasActiveEffects, IHasAbilities, IHasStats
    {
        Vector2 Position { get; set; }
        int MovementRange { get; set; }
        int FacingDirection { get; set; }
        int FactionType { get; set; }
    }
}