using OpenRpg.Tactics.Types;

namespace OpenRpg.Tactics.Grids
{
    public class AreaBuilder
    {
        private int _xSize = 3, _ySize = 3;
        private AreaCell[] _squares;

        public static AreaBuilder Create()
        { return new AreaBuilder(); }

        public AreaBuilder WithSize(int xSize, int ySize)
        {
            _xSize = xSize;
            _ySize = ySize;
            return this;
        }

        public AreaBuilder WithSquares(AreaCell[] squares)
        {
            _squares = squares;
            return this;
        }

        public AreaBuilder WithDefaultSquares()
        {
            var indexSize = _xSize * _ySize;
            var gridSquares = new AreaCell[indexSize];
            for (var i = 0; i < indexSize; i++)
            { gridSquares[i] = new AreaCell {GroundType = (byte)GroundTypes.Default, MovementCost = 1}; }

            _squares = gridSquares;
            return this;
        }

        public Area Build()
        {
            if (_squares == null)
            { WithDefaultSquares(); }
            
            return new Area
            {
                Squares = _squares,
                XSize = _xSize,
                YSize = _ySize
            };
        }
    }
}