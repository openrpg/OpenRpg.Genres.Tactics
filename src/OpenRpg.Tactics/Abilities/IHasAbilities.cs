using System.Collections.Generic;

namespace OpenRpg.Tactics.Abilities
{
    public interface IHasAbilities
    {
        IList<UnitAbility> Abilities { get; }
    }
}