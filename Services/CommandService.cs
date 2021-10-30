using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;
using Commander.Repository;
using Commander.Repository.Interfaces;
using Commander.Services.interfaces;

namespace Commander.Services
{
    public class CommandService: ICommandService
    {
        private readonly IMockCommanderRepository _repository;
        
        public CommandService(IMockCommanderRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Command>> GetAppCommands()
        {
            return _repository.GetAppCommands();
        }

        public Task<Command> GetCommandById(int id)
        {
            return _repository.GetCommandById(id);
        }

        public Task<Exception> Add(Command command)
        {
            return _repository.Add(command);
        }
    }
}