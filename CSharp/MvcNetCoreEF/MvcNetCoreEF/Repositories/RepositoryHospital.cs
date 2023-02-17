using MvcNetCoreEF.Data;
using MvcNetCoreEF.Models;

namespace MvcNetCoreEF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;

            return consulta.ToList();
        }

        public Hospital Detalles(int idhospital)
        {
            var consulta = from datos in this.context.Hospitales.AsEnumerable()
                           where datos.IdHospital == idhospital
                           select datos;
            return consulta.FirstOrDefault();
        }

        //public void InsertarHospital(int idhospital, string nombre, string direccion, string telefono, int camas)
        //{
        //    Hospital hosp = new Hospital();
        //    var consulta = from datos in this.context.Hospitales.AsEnumerable()
        //                   select datos;
        //    return consulta.FirstOrDefault(); 
        //}
    }
}
