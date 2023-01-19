using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        //CONSTRUCTOR VACIO
        public Direccion()
        {
            Debug.WriteLine("Constructor Direccion sin parametros");
        }

        public Direccion(string calle, string ciudad)
        {
            Calle = calle;
            Ciudad = ciudad;
            Debug.WriteLine("Constructor Direccion DOS paramtros");
        }
        public Direccion(string calle, string ciudad, int codigoPostal)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("Constructor Direccion TRES paramtros");
        }
    }
}
