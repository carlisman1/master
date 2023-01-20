using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empleado: Persona
    {
        protected int SalarioMinimo { get; set; }
        public int DiasVacaciones { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.SalarioMinimo = 1500;
            this.DiasVacaciones = 22;
        }
        public Empleado(string nombre, string apellidos)
        {
            Debug.WriteLine("constructor EMPLEADO dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public int GetDiasVacaciones()
        {
            return this.DiasVacaciones;
        }
    }
}
