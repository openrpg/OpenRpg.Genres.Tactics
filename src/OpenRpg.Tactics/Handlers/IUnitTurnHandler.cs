using System.Threading.Tasks;
using OpenRpg.Tactics.Units;

namespace OpenRpg.Tactics.Handlers
{
    public interface IUnitTurnHandler
    {
        Task TakeTurn(IUnit unit);
    }
}