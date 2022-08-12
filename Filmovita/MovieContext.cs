using Filmovita.Entity;
using Microsoft.EntityFrameworkCore;

namespace Filmovita
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieInfo> MovieInfo { get; set; }
    }

}
