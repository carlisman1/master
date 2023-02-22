using Microsoft.EntityFrameworkCore;
using MvcCoreMultiplesBBDD.Models;

namespace MvcCoreMultiplesBBDD.Data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext(DbContextOptions<EmpleadosContext> options)
            : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
