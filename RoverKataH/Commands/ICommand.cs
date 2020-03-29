using RoverKataH.Rover;

namespace RoverKataH.Commands
{
    public interface ICommand
    {
        void ExecuteCommand(IRover rover);
    }
}
