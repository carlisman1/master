using MvcCoreCrudDepartamentosEF.Data;
using MvcCoreCrudDepartamentosEF.Models;

namespace MvcCoreCrudDepartamentosEF.Repositories
{
    public class RepositoryDepartamento
    {

        private DepartamentosContext context;

        public RepositoryDepartamento(DepartamentosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        public Departamento FindDepartamento(int iddepartamento)
        {
            var consulta = from datos in this.context.Departamentos
                           where datos.IdDeptartamento == iddepartamento
                           select datos;
            return consulta.FirstOrDefault();
        }

        public int GetMaximo()
        {
            var maximo = (from datos in this.context.Departamentos select datos).Max(x=> x.IdDeptartamento);
            return maximo + 1;
        }

        public async Task InsertarDepartamento(string nombre, string localidad)
        {
            Departamento dept = new Departamento();
            dept.IdDeptartamento = this.GetMaximo();
            dept.Nombre = nombre;
            dept.Localidad = localidad;
            this.context.Departamentos.Add(dept);
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarDepartamento(int iddepartamento, string nombre, string localidad)
        {
            //BUSCAMOS EL MODEL DENTRO DEL CONTEXT
            Departamento dept = this.FindDepartamento(iddepartamento);
            //MODIFICAMOS LAS PROPIEDADES
            dept.Nombre = nombre;
            dept.Localidad = localidad;
            //GUARDAMOS CAMBIOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteDepartamento(int iddepartamento)
        {
            //BUSCAMOS EL MODEL DENTRO DEL CONTEXT
            Departamento dept = this.FindDepartamento(iddepartamento);
            this.context.Departamentos.Remove(dept);
            await this.context.SaveChangesAsync();
        }
    }
}
