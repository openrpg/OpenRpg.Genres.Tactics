using System.Linq;
using OpenRpg.Tactics.Abilities;
using OpenRpg.Tactics.Units;

namespace OpenRpg.Tactics.Extensions
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