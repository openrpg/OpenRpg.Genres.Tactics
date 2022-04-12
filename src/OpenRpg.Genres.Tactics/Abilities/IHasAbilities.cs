using System.Collections.Generic;

namespace OpenRpg.Genres.Tactics.Abilities
{
    public interface IHasAbilities
    {
        IList<UnitAbility> Abilities { get; }
    }
}