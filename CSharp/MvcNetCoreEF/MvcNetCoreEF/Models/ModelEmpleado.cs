namespace MvcNetCoreEF.Models
{
    public class ModelEmpleado
    {
        public List<Empleado> Empleados { get; set; }
        public int SumaSalarial { get; set; }
        public double MediaSalarial { get; set; }
    }
}
