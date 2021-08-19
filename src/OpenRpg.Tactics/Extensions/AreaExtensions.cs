using OpenRpg.Tactics.Grids;
using OpenRpg.Tactics.Types;

namespace OpenRpg.Tactics.Extensions
{
    public static class AreaExtensions
    {
        public static bool IsInvalidCell(this AreaCell cell)
        { return cell.GroundType == GroundTypes.InvalidGround; }
        
        public static AreaCell GetCellAt(this Area area, int x, int y)
        {
            if(x < 0 || y < 0){ return AreaCell.Empty; }
            if(x >= area.XSize || y >= area.YSize) { return AreaCell.Empty; }
            return area.Squares[(area.XSize * y) + x];
        }
        
        public static AreaCell[] GetCellsAround(this Area area, int x, int y)
        {
            var squares = new AreaCell[9];
            var index = 0;
            for (var iy = y-1 - 1; iy <= y+1; iy++)
            {
                for (var ix = x-1 - 1; ix <= x+1; ix++)
                {
                    if (iy < 0 || ix < 0)
                    { squares[index++] = AreaCell.Empty; }

                    squares[index++] = area.GetCellAt(x, y);
                }
            }
            return squares;
        }
        
        public static AreaCell GetSquareAbove(this Area area, int x, int y)
        { return area.Squares[(area.XSize * (y+1)) + x]; }
    }
}