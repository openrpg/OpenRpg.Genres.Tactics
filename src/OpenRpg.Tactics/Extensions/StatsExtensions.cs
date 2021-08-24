using OpenRpg.Core.Stats;
using OpenRpg.Tactics.Types;

namespace OpenRpg.Tactics.Extensions
{
    public static class StatsExtensions
    {
        public static int Initiative(this IStatsVariables stats)
        { return (int)stats.Get(TacticsStatsVariableTypes.Initiative); }

        public static void Initiative(this IStatsVariables stats, int initiative)
        { stats[TacticsStatsVariableTypes.Initiative] = initiative; }
        
        public static int Experience(this IStatsVariables stats)
        { return (int)stats.Get(TacticsStatsVariableTypes.Experience); }
        
        public static void SetExperience(this IStatsVariables stats, int experience)
        { stats[TacticsStatsVariableTypes.Experience] = experience; }

        public static void AddExperience(this IStatsVariables stats, int experience)
        {
            var currentExperience = stats.Get(TacticsStatsVariableTypes.Experience);
            stats[TacticsStatsVariableTypes.Experience] = (int)(currentExperience + experience);
        }
        
        public static void RemoveExperience(this IStatsVariables stats, int experience)
        {
            var currentExperience = stats.Get(TacticsStatsVariableTypes.Experience);
            stats[TacticsStatsVariableTypes.Experience] = (int)(currentExperience - experience);
        }
    }
}