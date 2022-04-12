using System.Linq;
using OpenRpg.Genres.Tactics.Abilities;
using OpenRpg.Genres.Tactics.Units;

namespace OpenRpg.Genres.Tactics.Extensions
{
    public static class UnitExtensions
    {
        public static UnitAbility GetAbility(this IUnit unit, int abilityId)
        { return unit.Abilities.FirstOrDefault(x => x.Id == abilityId); }
        
        public static bool HasPassiveAbility(this IUnit unit)
        { return unit.Abilities.Any(x => x.IsPassive); }

        public static bool IsUnitWithinRange(this IUnit unit, IUnit target, int range)
        { return target.Position.GetLocationsInRange(range).Any(x => unit.Position.X == x.X && unit.Position.Y == x.Y); }
    }
}