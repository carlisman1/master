using MvcNetCoreEF.Data;
using MvcNetCoreEF.Models;

namespace MvcNetCoreEF.Repositories
{
    public class RepositoryEmpleados
    {
        private HospitalContext context;

        public RepositoryEmpleados(HospitalContext context)
        {
            this.context = context;
        }

        public List<string> GetOficios()
        {
            var consulta = (from datos in this.context.Empleados
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }

        public async Task<ModelEmpleado> IncrementarSalariosAsync
            (int incremento, string oficio)
        {
            List<Empleado> empleados = this.GetEmpleadosOficio(oficio);
            foreach (Empleado emp in empleados)
            {
                emp.Salario += incremento;
            }
            await this.context.SaveChangesAsync();
            //DEVOLVER LOS EMPLEADOS, LA MEDIA Y LA SUMA SALARIAL
            int suma = empleados.Sum(z => z.Salario);
            double media = empleados.Average(z => z.Salario);
            ModelEmpleado model = new ModelEmpleado();
            model.SumaSalarial = suma;
            model.MediaSalarial = media;
            model.Empleados = empleados;
            return model;
        }

    }
}
