using MvcCorePaginacionRegistros.Data;
using MvcCorePaginacionRegistros.Models;

namespace MvcCorePaginacionRegistros.Repositories
{
    public class RepositoryEmpleados
    {
        private DepartamentosContext context;

        public RepositoryEmpleados(DepartamentosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleadosOficioDept(int deptno)
        {
            var consulta = from datos in this.context.Empleado
                           where datos.DeptNo == deptno
                           select datos;
            return consulta.ToList();
        }
    }
}
