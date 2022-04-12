using System.Numerics;
using System.Threading.Tasks;
using OpenRpg.Genres.Tactics.Units;

namespace OpenRpg.Genres.Tactics.Handlers
{
    public interface ITargetLocationAbilityHandler : IAbilityHandler
    {
        Task<bool> ExecuteAbility(IUnit unit, Vector2 targetLocation);
    }
}