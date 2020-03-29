using RoverKataH.Rover;

namespace RoverKataH.Commands
{
    public class TurnRightCommand : ICommand
    {
        public void ExecuteCommand(IRover rover)
        {
            rover.TurnRight();
        }
    }
}
