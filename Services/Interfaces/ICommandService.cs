using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Services.interfaces
{
    public interface ICommandService
    {
        Task<List<Command>> GetAppCommands();
        Task<Command> GetCommandById(int id);
        Task<Exception> Add(Command command);
    }
}