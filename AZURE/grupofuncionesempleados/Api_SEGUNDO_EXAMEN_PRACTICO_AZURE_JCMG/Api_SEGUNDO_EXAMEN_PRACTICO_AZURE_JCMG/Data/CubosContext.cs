using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Data
{
    public class CubosContext:DbContext
    {
        public CubosContext(DbContextOptions<CubosContext> options)
            : base(options) { }
        public DbSet<Cubos> NCubos { get; set; }
        public DbSet<CompraCubos> CCubos { get; set; }
        public DbSet<UsuarioCubos> UCubos { get; set; }
    }
}
