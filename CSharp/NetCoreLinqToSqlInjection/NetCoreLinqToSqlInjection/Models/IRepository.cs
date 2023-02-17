namespace NetCoreLinqToSqlInjection.Models
{
    public interface IRepository
    {
        List<Doctor> GetDoctor();
        void InsertDoctor(string hospitalCod, string doctorCod, string apellido, string especialidad, int salario );
        void DeleteDoctor(int iddoctor);
    }
}
