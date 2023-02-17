using MvcCoreCrudHospitalesEF.Data;
using MvcCoreCrudHospitalesEF.Models;

namespace MvcCoreCrudHospitalesEF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalesContext context;

        public RepositoryHospital(HospitalesContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        public Hospital FindHospital(int hospitalCod)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.HospitalCod == hospitalCod
                           select datos;
            return consulta.FirstOrDefault();
        }

        public int GetMaximo()
        {
            var maximo = (from datos in this.context.Hospitales select datos).Max(x => x.HospitalCod);
            return maximo + 1;
        }

        public async Task InsertarHospital(string nombre, string direccion, string telefono, int numCama)
        {
            Hospital hosp = new Hospital();
            hosp.HospitalCod = this.GetMaximo();
            hosp.Nombre = nombre;
            hosp.Direccion = direccion;
            hosp.Telefono = telefono;
            hosp.NumCama = numCama;
            this.context.Hospitales.Add(hosp);
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarHospital(int hospitalCod, string nombre, string direccion, string telefono, int numCama)
        {
            Hospital hosp = this.FindHospital(hospitalCod);
            hosp.Nombre = nombre;
            hosp.Direccion = direccion;
            hosp.Telefono = telefono;
            hosp.NumCama = numCama;
            await this.context.SaveChangesAsync();
        }

        public async Task EliminarHospital(int hospitalCod)
        {
            Hospital hosp = this.FindHospital(hospitalCod);
            this.context.Hospitales.Remove(hosp);
            await this.context.SaveChangesAsync();
        }
    }
}
