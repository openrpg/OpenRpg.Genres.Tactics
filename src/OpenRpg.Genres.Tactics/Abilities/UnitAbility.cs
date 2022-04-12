using OpenRpg.Combat.Abilities;

namespace OpenRpg.Genres.Tactics.Abilities
{
    public class UnitAbility : Ability
    {
        public bool IsPassive { get; set; }
        public int Range { get; set; } = 1;
        public AbilityShape Shape { get; set; } = ShapePresets.Empty;
        public int DamageType { get; set; }
    }
}