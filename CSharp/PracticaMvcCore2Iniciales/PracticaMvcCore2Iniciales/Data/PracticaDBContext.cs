using Microsoft.EntityFrameworkCore;
using PracticaMvcCore2Iniciales.Models;

namespace PracticaMvcCore2Iniciales.Data
{
    public class PracticaDBContext: DbContext
    {
        public PracticaDBContext(DbContextOptions<PracticaDBContext> options) : base(options) { }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Generos> Generos { get; set; }
    }
}
