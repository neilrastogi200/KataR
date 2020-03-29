using RoverKataH.Rover;

namespace RoverKataH.Commands
{
    public class MoveForwardCommand : ICommand
    {
        public void ExecuteCommand(IRover rover)
        {
            rover.Forward();
        }
    }
}
