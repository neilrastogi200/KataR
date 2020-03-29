using RoverKataH.Rover;

namespace RoverKataH.Commands
{
    public class TurnLeftCommand : ICommand
    {
        public void ExecuteCommand(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}
