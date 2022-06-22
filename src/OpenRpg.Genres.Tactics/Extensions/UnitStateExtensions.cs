using OpenRpg.Genres.Tactics.Types;
using OpenRpg.Genres.Variables;

namespace OpenRpg.Genres.Tactics.Extensions
{
    public static class UnitStateExtensions
    {
        public static int Experience(this ICharacterStateVariables state)
        { return (int)state.Get(UnitStateVariableTypes.Experience); }
        
        public static void SetExperience(this ICharacterStateVariables state, int experience)
        { state[UnitStateVariableTypes.Experience] = experience; }

        public static void AddExperience(this ICharacterStateVariables state, int experience)
        {
            var currentExperience = state.Get(UnitStateVariableTypes.Experience);
            state[UnitStateVariableTypes.Experience] = (int)(currentExperience + experience);
        }
        
        public static void RemoveExperience(this ICharacterStateVariables state, int experience)
        {
            var currentExperience = state.Get(UnitStateVariableTypes.Experience);
            state[UnitStateVariableTypes.Experience] = (int)(currentExperience - experience);
        }
    }
}