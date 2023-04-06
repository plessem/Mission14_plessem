using Microsoft.EntityFrameworkCore;
using Mission14API.Models;

namespace Mission14API.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Movie> Movies { get; set; }

    }
}
