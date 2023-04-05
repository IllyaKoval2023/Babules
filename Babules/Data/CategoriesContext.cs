using Babules.Models;
using Microsoft.EntityFrameworkCore;

public class CategoriesContext : DbContext
{
    public CategoriesContext(DbContextOptions<CategoriesContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}