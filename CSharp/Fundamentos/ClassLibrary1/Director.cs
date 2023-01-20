using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
            this.DiasVacaciones += 7;
        }
        //OVERRIDE
        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacacones() DIRECTOR");
            int DiasVacaciones = base.GetDiasVacaciones();
            return DiasVacaciones;
        }

        public override string ToString()
        {
            return this.GetNombreCompleto()+", Salario: "+this.SalarioMinimo+", Vacaciones:"+this.GetDiasVacaciones();
        }
    }
}
