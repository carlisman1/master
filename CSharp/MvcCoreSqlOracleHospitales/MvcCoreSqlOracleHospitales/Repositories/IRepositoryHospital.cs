using MvcCoreSqlOracleHospitales.Models;

namespace MvcCoreSqlOracleHospitales.Repositories

{
    public interface IRepositoryHospital
    {
        List<Hospital> GetHospitales();
        Hospital Detalles(int idhospital);
        void InsertarHospital(int idhospital, string nombre, string direccion, string telefono, int numCama);
        void ModificarHospital(int idhospital, string nombre, string direccion, string telefono, int numCama);
        void EliminarHospital(int idhospital);
    }
}
