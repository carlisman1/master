using ApiSeriesExamenJCMG.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSeriesExamenJCMG.Data
{
    public class SeriesContext:DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options)
            : base(options) { }
        public DbSet<Personaje> Personaje { get; set; }
    }
}
