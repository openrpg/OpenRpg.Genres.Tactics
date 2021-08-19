using OpenRpg.Combat.Abilities;

namespace OpenRpg.Tactics.Abilities
{
    public class UnitAbility : Ability
    {
        public bool IsPassive { get; set; }
        public int Range { get; set; } = 1;
        public AbilityShape Shape { get; set; } = ShapePresets.Empty;
        public int DamageType { get; set; }
    }
}