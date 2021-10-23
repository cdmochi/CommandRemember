using System;
using System.Collections.Generic;
using Commander.Data;
using CommanderModels;

namespace Commander.Data
{
    public class MockCommanderRepositoryImpl : IMockCommanderRepository
    {
        public IEnumerable<Command> GetAppCommands()
        {
            List<Command> commands = new List<Command>
                {
                    new Command { Id = 0, HowTo = "Give User Privilledge to Do as a Super User", Line = "sudo", Platform = "Linux" },
                    new Command { Id = 1, HowTo = "Give Write/Read or Excute permission too file", Line = "chmod", Platform = "Linux" }
                };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = id,
                HowTo = "Give User Privilledge to Do as a Super User",
                Line = "sudo",
                Platform = "Linux"
            };
        }
    }
}