using Babules.Models;
using Microsoft.EntityFrameworkCore;

namespace Babules.Data
{
    public class OperationsContext : DbContext
    {
        public OperationsContext(DbContextOptions<OperationsContext> options) : base(options)
        {
        }

        public DbSet<Operations> Operations { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
