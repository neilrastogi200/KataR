using System.Collections.Generic;

namespace RoverKataH.Commands
{
    public interface ICommandList
    {
        Dictionary<string, ICommand> AvailableCommandList { get; }
    }
}