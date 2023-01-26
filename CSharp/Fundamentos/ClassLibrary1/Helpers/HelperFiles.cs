using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ProyectoClases.Helpers
{
    
    public class HelperFiles
    {
        //NECESITAMOS UN METODPO PARA LEER FICHEROS
        //ESTE METODO DEVUELVE EL STRING DEL FILE
        //EN LAS CLASES, LOS METODOS ASINCRONOS
        //UTILIZAN LA CLASE Task PARA SU DECLARACION
        //SI ES UN void, SIMPLEMENTE LA PALABRA Task
        //SI ES UN return, SE UTILIZA Task<Tipo>
        public static async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            //PARA LEER VAMOS A UTILIZAR using
            //PARA ASEGURARNOS DENTRO DEL CODIGO
            //EL OBJETO SIEMPRE ESTARA ACCESIBLE
            using (TextReader reader = file.OpenText())
            {
                //DENTRO DE ESE CODIGO DEBEMOS UTILIZAR READER
                //Y DESPUES QUEDARA DESTRUIDO
                string contenido = await reader.ReadToEndAsync();
                reader.Close();
                return contenido;

            }
        }
        //METODO PARA ESCRIBIR EN UN FILE
        //ESTE METODO ES DE ACCION (void)
        //NO DEVULEVE NADA
        public static async Task WriteFileAsync(string path, string data)
        {
            FileInfo fileInfo = new FileInfo(path);
            using (TextWriter writer = fileInfo.CreateText())
            {
                await writer.WriteAsync(data);
            }
        }

        public static byte[] saveImage(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            return data;
        } 
    }
}
