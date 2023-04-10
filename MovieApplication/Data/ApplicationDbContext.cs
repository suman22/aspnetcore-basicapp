using App.Movie;
using Microsoft.EntityFrameworkCore;

namespace MovieApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :  base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddMovieEntity();
             base.OnModelCreating(builder);
        }
    }
}
