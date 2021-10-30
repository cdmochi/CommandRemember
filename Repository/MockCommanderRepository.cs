using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Data;
using Commander.Models;
using Commander.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Commander.Repository
{
    public class MockCommanderRepository : IMockCommanderRepository
    {
        private readonly ApplicationDbContext _db;
        public MockCommanderRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Command>> GetAppCommands()
        {
            return await _db.Commanders
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Exception> Delete(int id)
        {
            var command = _db.Commanders.SingleOrDefault(x => x.Id == id);
            if (command == null)
            {
                throw new Exception("Command does not exist in the Database");
            }

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                return exception;
            }

            return null;
        }

        public async Task<Exception> Add(Command command)
        {
            try
            {
                _db.Add(command);
                await _db.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                return exception;
            }

            return null;
        }

        public  async Task<Command> GetCommandById(int id)
        {
            var queryCommand = await _db.Commanders
                .OrderBy(x => x.Id == id)
                .FirstOrDefaultAsync();

            return queryCommand;
        }
    }
}