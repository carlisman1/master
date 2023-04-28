namespace MvcCoreApiCrudDoctor.Models
{
    public class Doctor
    {
        public string IdHospital { get; set; }
        public string IdDoctor { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public int Salario { get; set; }
    }
}
