using OpenRpg.Combat.Attacks;
using OpenRpg.Core.Common;
using OpenRpg.Genres.Tactics.Units;

namespace OpenRpg.Genres.Tactics.Handlers
{
    public interface IAbilityHandler : IHasDataId
    {
        Attack CalculateAttack(IUnit unit);
    }
}