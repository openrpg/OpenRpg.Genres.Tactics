using OpenRpg.Core.State.Entity;
using OpenRpg.Genres.Tactics.Types;

namespace OpenRpg.Genres.Tactics.Extensions
{
    public static class UnitStateExtensions
    {
        public static int Experience(this IEntityStateVariables state)
        { return (int)state.Get(UnitStateVariableTypes.Experience); }
        
        public static void SetExperience(this IEntityStateVariables state, int experience)
        { state[UnitStateVariableTypes.Experience] = experience; }

        public static void AddExperience(this IEntityStateVariables state, int experience)
        {
            var currentExperience = state.Get(UnitStateVariableTypes.Experience);
            state[UnitStateVariableTypes.Experience] = (int)(currentExperience + experience);
        }
        
        public static void RemoveExperience(this IEntityStateVariables state, int experience)
        {
            var currentExperience = state.Get(UnitStateVariableTypes.Experience);
            state[UnitStateVariableTypes.Experience] = (int)(currentExperience - experience);
        }
    }
}