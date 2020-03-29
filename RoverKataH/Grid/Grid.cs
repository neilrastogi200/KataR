namespace RoverKataH.Grid
{
    public class Grid : IGrid
    {
        private readonly int _gridSize;

        public Grid(int gridSize)
        {
            CoordinateX = 0;
            CoordinateY = 0;
            _gridSize = gridSize;
        }

        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        public bool IncreaseForwardPositionY()
        {
       
            if (CoordinateY < _gridSize)
            {
                CoordinateY++;

            }
            return true;
        }

        public bool IncreaseForwardPositionX()
        {
            if (CoordinateX < _gridSize)
            {
                CoordinateX++;
                return false;
            }

            return true;
        }

        public bool DecreaseBackwardPositionY()
        {
            if (CoordinateY > 0)
            {
                CoordinateY--;
            }

            return true;
        }

        public bool DecreaseBackwardPositionX()
        {
            if (CoordinateX > 0)
            {
                CoordinateX--;
            }

            return true;
        }

    }
}