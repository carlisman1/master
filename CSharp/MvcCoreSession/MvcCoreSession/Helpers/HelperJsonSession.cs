using MvcCoreSession.Models;
using Newtonsoft.Json;

namespace MvcCoreSession.Helpers
{
    public class HelperJsonSession
    {
        //public static Persona DeserealizarPersona(string data)
        //{
        //    Persona persona =
        //        JsonConvert.DeserealizarObject<Persona>(data);
        //    return persona;
        //}
        public static T DeserealizarObject<T>(string data)
        {
            T objeto =
                JsonConvert.DeserializeObject<T>(data);
            return objeto;
        }

        public static void SerializeObject()
        {




        }
    }
}
