using System.Threading.Tasks;
using OpenRpg.Genres.Tactics.Units;

namespace OpenRpg.Genres.Tactics.Handlers
{
    public interface IUnitTurnHandler
    {
        Task TakeTurn(IUnit unit);
    }
}