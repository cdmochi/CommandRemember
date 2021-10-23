using System.Collections.Generic;
using Commander.Data;
using Commander.Controllers;
using CommanderModels;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers {

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IMockCommanderRepository _repository;

        public CommandsController(IMockCommanderRepository repository) 
        {
            _repository = repository;
        }

        //private readonly IMockCommanderRepositoryImpl _repository = new MockCommanderRepositoryImpl();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands() 
        {
            var commands = _repository.GetAppCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetThingWithId(int id) 
        {
            var thing = _repository.GetCommandById(id);
            return Ok(thing);
        }
    }

}

