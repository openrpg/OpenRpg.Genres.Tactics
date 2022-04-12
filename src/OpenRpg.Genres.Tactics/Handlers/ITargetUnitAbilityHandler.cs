using System.Threading.Tasks;
using OpenRpg.Genres.Tactics.Units;

namespace OpenRpg.Genres.Tactics.Handlers
{
    public interface ITargetUnitAbilityHandler : IAbilityHandler
    {
        Task<bool> ExecuteAbility(IUnit unit, IUnit targetUnit);
    }
}