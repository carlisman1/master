using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    #region ENUMERACIONES
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Italia, Francia }
    #endregion

    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacio");
            this.DomicilioVacaciones = new Direccion("AA", "AAA", 7777);
        }

        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor PERSONA dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        #region CAMPOS DE PROPIEDAD
            private TipoGenero _Genero;
            private int _Edad;
        #endregion

        #region PROPIEDADES
        public TipoGenero Genero
        {
            get
            {
                return this._Genero;
            }
            set
            {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("El valor no es valido");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }

        public string Apellidos { get; set; }



        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                //AQUI PREGUNTAMOS EL DATO QUE QUEREMOS PREGUNTAR
                if (value < 0)
                {
                    throw new Exception("la edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region METODOS

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //QUEREMOS DEVOLVER EL NOMNBRE COMPLETO EN ORDEN INVERSO
        public string GetNombreInverso()
        {
            return this.Apellidos + " " + this.Nombre;
        }

        //QUEREMOS DEVOLVER EL NOMBRE COMPLETO EN MAYUSCULAS
        public string GetNombreMayusculas(bool orden)
        {
            if(orden== true)
            {
                return this.Nombre.ToUpper() + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreInverso();
            }
            
        }
        public void MetodoParametrosOpcionales(int numero1,int numero2=22)
        {

        }
        #endregion

    }
}