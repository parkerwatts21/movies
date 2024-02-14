using Microsoft.EntityFrameworkCore;

namespace Mission07_Watts.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options) //Constructor
        {

        }

        public DbSet<Application> Applications { get; set; }
    }
}
