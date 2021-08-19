using System.Threading.Tasks;
using OpenRpg.Tactics.Units;

namespace OpenRpg.Tactics.Handlers
{
    public interface ITargetUnitAbilityHandler : IAbilityHandler
    {
        Task<bool> ExecuteAbility(IUnit unit, IUnit targetUnit);
    }
}