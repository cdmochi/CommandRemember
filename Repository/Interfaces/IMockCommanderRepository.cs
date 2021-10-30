using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Repository.Interfaces 
{
    public interface IMockCommanderRepository
    {
        Task<List<Command>> GetAppCommands();
        Task<Command> GetCommandById(int id);
        Task<Exception> Delete(int id);
        Task<Exception> Add(Command command);
    }
}