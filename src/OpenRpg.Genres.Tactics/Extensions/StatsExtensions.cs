using OpenRpg.Core.Stats;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Tactics.Types;

namespace OpenRpg.Genres.Tactics.Extensions
{
    public static class StatsExtensions
    {
        public static int Initiative(this IStatsVariables stats)
        { return (int)stats.Get(TacticsStatsVariableTypes.Initiative); }

        public static void Initiative(this IStatsVariables stats, int initiative)
        { stats[TacticsStatsVariableTypes.Initiative] = initiative; }
    }
}