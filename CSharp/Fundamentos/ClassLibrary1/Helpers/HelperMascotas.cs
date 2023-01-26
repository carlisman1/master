using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }
        //TENDREMOS METODOS QUE SERAN LAS TRIPAS DE LA CLASE
        //VAMOS A LEER UN FILE Y CONTENDRA UN TEXTO CON LAS MASCOTAS
        //  GARFIELS#GATO,REX#PERRO
        private void CreateMascotas(string data)
        {
            //LIMPIAMOS LA COLECCION
            this.Mascotas.Clear();
            //SEPARAMOS LOS OBJETOS
            string[] datosmascotas = data.Split(',');
            foreach (string d in datosmascotas)
            {
                //GARFIELS#GATO
                //SEPARAMOS CADA PROPIEDAD
                string[] propiedades = d.Split('#');
                Mascota mascota = new(){ Nombre = propiedades[0],Raza = propiedades[1] };
                this.Mascotas.Add(mascota);
            }
        }
        //CUANDO LEAMOS EL FICHERO DE MASCOTAS, LAS CREAREMOS
        //NECESITAMOS LA RUTA
        public async Task ReadFileMascotasAsync(string path)
        {
            //EXTRAEMOS EL CONTENIDO DEL FICHERO
            string data = await HelperFiles.ReadFileAsync(path);
            this.CreateMascotas(data);
        }

        //AL ESCRIBIR VAMOS A DIBUJAR TODAS LAS MASCOTAS 
        //CON LOS SEPARADORES QUE HEMOS PENSADO
        //  GARFIELS#GATO,REX#PERRO
        private string GetMascotasString()
        {
            string data = "";
            //RECORREMOS LA COLECCION List <Mascota>
            //Y LE DAMOS FORMATO STRING
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                 data += temp + ",";
            }
            data = data.Trim(',');
            data = data.Trim('#');
            return data;
        }
        public async Task SaveFileMascotasAsync(string path)
        {
            string data = this.GetMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }
    }
}
