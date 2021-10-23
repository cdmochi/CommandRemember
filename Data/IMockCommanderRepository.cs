using System.Collections.Generic;
using CommanderModels;

namespace Commander.Data 
{
    public interface IMockCommanderRepository
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}