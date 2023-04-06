using Babules.Models;
using Microsoft.EntityFrameworkCore;

namespace Babules.Data
{
    public class BabulesContext : DbContext
    {
        public BabulesContext(DbContextOptions<BabulesContext> options) : base(options)
        {
        }

        public DbSet<Operations> Operations { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
