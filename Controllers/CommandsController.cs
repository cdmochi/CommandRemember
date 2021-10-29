using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
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

