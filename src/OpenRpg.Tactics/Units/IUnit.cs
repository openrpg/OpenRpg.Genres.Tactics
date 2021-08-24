using System.Numerics;
using OpenRpg.Combat.Effects;
using OpenRpg.Genres.Characters;
using OpenRpg.Tactics.Abilities;

namespace OpenRpg.Tactics.Units
{
    public interface IUnit : ICharacter, IHasActiveEffects, IHasAbilities
    {
        Vector2 Position { get; set; }
        int MovementRange { get; set; }
        int FacingDirection { get; set; }
        int FactionType { get; set; }
    }
}