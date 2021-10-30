using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) { }
        public DbSet<Command> Commanders { get; set; }
    }
}
