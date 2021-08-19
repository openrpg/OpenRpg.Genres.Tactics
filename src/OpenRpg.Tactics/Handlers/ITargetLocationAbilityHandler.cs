using System.Numerics;
using System.Threading.Tasks;
using OpenRpg.Tactics.Units;

namespace OpenRpg.Tactics.Handlers
{
    public interface ITargetLocationAbilityHandler : IAbilityHandler
    {
        Task<bool> ExecuteAbility(IUnit unit, Vector2 targetLocation);
    }
}