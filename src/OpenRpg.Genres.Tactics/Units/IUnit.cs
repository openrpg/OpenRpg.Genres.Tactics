using System.Numerics;
using OpenRpg.Core.Effects;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Tactics.Abilities;

namespace OpenRpg.Genres.Tactics.Units
{
    public interface IUnit : ICharacter, IHasEffects, IHasAbilities
    {
        Vector2 Position { get; set; }
        int MovementRange { get; set; }
        int FacingDirection { get; set; }
        int FactionType { get; set; }
    }
}