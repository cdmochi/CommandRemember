using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;
using Commander.Repository;
using Commander.Repository.Interfaces;
using Commander.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers {

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandService _service;

        public CommandsController(ICommandService service)
        {
            _service = service;
        }
        //GET api/commands
        [HttpGet]
        public ActionResult <List<Command>> GetAllCommands() 
        {
            var commands = _service.GetAppCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) 
        {
            var commandTask = _service.GetCommandById(id);
            return Ok(commandTask);
        }

        public ActionResult<Exception> Add(Command command)
        {
            var task = _service.Add(command);
            return Ok(task);
        }
    }
}