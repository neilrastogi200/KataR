namespace RoverKataH.Grid
{
    public interface IGrid
    {
        int CoordinateX { get; }
        int CoordinateY { get; }
        bool IncreaseForwardPositionY();
        bool IncreaseForwardPositionX();
        bool DecreaseBackwardPositionY();
        bool DecreaseBackwardPositionX();

    }
}
