using OpenRpg.Genres.Tactics.Types;

namespace OpenRpg.Genres.Tactics.Areas
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