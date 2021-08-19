using System.Numerics;
using System.Threading.Tasks;
using OpenRpg.Combat.Attacks;
using OpenRpg.Core.Common;
using OpenRpg.Tactics.Units;

namespace OpenRpg.Tactics.Handlers
{
    public interface IAbilityHandler : IHasDataId
    {
        Attack CalculateAttack(IUnit unit);
    }
}