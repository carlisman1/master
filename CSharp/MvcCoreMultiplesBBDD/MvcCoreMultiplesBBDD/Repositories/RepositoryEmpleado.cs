using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Models;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public class RepositoryEmpleado
    {
        private EmpleadosContext context;

        public RepositoryEmpleado (EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados() 
        {
            var consulta = from datos in this.context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public Empleado Details(int empno)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.EmpNo == empno
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}
