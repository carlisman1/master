using Microsoft.EntityFrameworkCore;
using MvcCoreCrudDepartamentosEF.Models;
using MvcCoreCrudDepartamentosEF.Repositories;

namespace MvcCoreCrudDepartamentosEF.Data
{
    public class DepartamentosContext : DbContext
    {

        public DepartamentosContext(DbContextOptions<DepartamentosContext> options)
            : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
