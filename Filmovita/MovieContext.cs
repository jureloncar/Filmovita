using Microsoft.EntityFrameworkCore;

namespace Filmovita
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        DbSet<Movie> Movies { get; set; } = null!;
    }
}
