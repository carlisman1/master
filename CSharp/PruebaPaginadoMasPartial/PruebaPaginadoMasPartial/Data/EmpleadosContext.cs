using Microsoft.EntityFrameworkCore;
using PruebaPaginadoMasPartial.Models;

namespace PruebaPaginadoMasPartial.Data
{
    public class EmpleadosContext :DbContext
    {
        public EmpleadosContext(DbContextOptions<EmpleadosContext> options)
            : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
