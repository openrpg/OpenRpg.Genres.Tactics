using OpenRpg.Tactics.Types;

namespace OpenRpg.Tactics.Grids
{
    public struct AreaCell
    {
        public byte GroundType { get; set; }
        public byte Height { get; set; }
        public byte MovementCost { get; set; }

        public static AreaCell Empty = new AreaCell
        { GroundType = GroundTypes.InvalidGround };
    }
}