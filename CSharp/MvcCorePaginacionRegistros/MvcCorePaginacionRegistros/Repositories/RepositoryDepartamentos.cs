using MvcCorePaginacionRegistros.Data;
using MvcCorePaginacionRegistros.Models;

namespace MvcCorePaginacionRegistros.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentosContext context;

        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepts()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        //public Departamento FindDepartamento(int iddepartamento)
        //{
        //    var consulta = from datos in this.context.Departamentos
        //                   where datos.DeptNo == iddepartamento
        //                   select datos;
        //    return consulta.FirstOrDefault();
        //}
    }

}
