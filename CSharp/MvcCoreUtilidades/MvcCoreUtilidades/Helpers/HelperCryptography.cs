using System.Security.Cryptography;
using System.Text;

namespace MvcCoreUtilidades.Helpers
{
    public class HelperCryptography
    {
        //CREAMOS UN METODO STATIC PARA CIFRAR UN STRING
        //DE FORMA MUY BASICA. DEVOLVEMOS EL STRING GENERADO
        public static string EncriptarTextoBasico(string contenido)
        {
            //NECESITAMOS A NIVEL DE BYTR[]
            //DEBEMOS CONVERTIR EL TEXTO RECIBIDO A BYTE[]
            byte[] entrada;
            SHA1Managed sHA1 = new SHA1Managed();
            //UNA VEZ CONVERTIDO EL CIFRADO, NOS DEVUELVE
            //UN BYTE[] DE SALIDA
            byte[] salida;
            //NECESITAMOS UN CONVERSOR PARA CONVERTIR STRING A BYTE[]
            //Y VICEVERSA
            UnicodeEncoding encoding = new UnicodeEncoding();
            //NECESITAMOS UN OBJETO STRING A BYTE[]
            entrada = encoding.GetBytes(contenido);
            //EL OBJETO SHA1 RECIBE UN ARRAY DE BYTES E 
            //INTERNAMENTE HACE "ALGO" PARA DEVOLVER OTRO ARRAY DE BYTES
            salida = sHA1.ComputeHash(entrada);
            string resultado = encoding.GetString(salida);
            return resultado;
        }
    }
}
