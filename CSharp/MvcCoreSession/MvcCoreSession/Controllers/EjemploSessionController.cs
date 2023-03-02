using Microsoft.AspNetCore.Mvc;
using MvcCoreSession.Helpers;
using MvcCoreSession.Models;

namespace MvcCoreSession.Controllers
{
    public class EjemploSessionController : Controller
    {
        int numero = 1;

        public IActionResult Index()
        {
            ViewData["NUMERO"] = "Valor del numero: " + this.numero;
            return View();
        }

        public IActionResult SessionSimple(string accion)
        {
            if(accion != null)
            {       
                if (accion.ToLower() == "almacenar")
                {
                    HttpContext.Session.SetString("nombre", "Programeitor");
                    HttpContext.Session.SetString("hora", 
                        DateTime.Now.ToLongTimeString());
                    ViewData["MENSAJE"] = "Datos almacenados en Session";
                }
                else if (accion.ToLower() == "mostrar")
                {
                    ViewData["USUARIO"] =
                        HttpContext.Session.GetString("nombre");
                    ViewData["HORA"] =
                        HttpContext.Session.GetString("hora");
                }
            }

            return View();
        }

        public IActionResult SessionPersona(string accion)
        {
            if(accion != null)
            {       
                if (accion.ToLower() == "almacenar")
                {
                    Persona persona = new Persona();
                    persona.Nombre = "Alumno";
                    persona.Email = "pepe@gmail.com";
                    persona.Edad = 25;
                    //DEBEMOS CONVERTIR EL OBJETO PERSONA
                    //A BYTE[] PARA ALAMACENARLO EN SESSION
                    byte[] data =
                        HelperBinarySession.ObjectToByte(persona);
                    //ALMACENAMOS EL OBJETO BINARIO EN SESSION
                    HttpContext.Session.Set("PERSONA", data);
                    ViewData["Mensaje"] = "Datos almacenados";
                }
                else if (accion.ToLower() == "mostrar")
                {
                    //EXTRAEMOS EL OBJETO PERSONA DESDE LOS BYTES[]
                    //DE SESSION
                    byte[] data = HttpContext.Session.Get("PERSONA");
                    //CONVERTIMOS EL BINARIO A OBJETO
                    Persona persona = (Persona)
                        HelperBinarySession.ByteToObject(data);
                    ViewData["PERSONA"] = persona;
                }
            }

            return View();
        }
        public IActionResult ColeccionSessionPersona(string? accion)
        {
            if (accion == null)
            {
                return View();
            }

            if (accion.ToLower() == "almacenar")
            {
                List<Persona> personas = new()
                {
                new Persona()
                {
                Edad = 25,
                Nombre = "Marta",
                Email = "marta@gmail.com" },
                new Persona()
                {
                Edad = 35,
                Nombre = "Andrés",
                Email = "andres@gmail.com" },
                new Persona()
                {
                Edad = 45,
                Nombre = "Paco",
                Email = "paco@gmail.com" },
                };

                byte[] data = HelperBinarySession.ObjectToByte(personas)!;
                HttpContext.Session.Set("PERSONAS", data);
                ViewData["MENSAJE"] = "Datos almacenados";
            }
            else if (accion.ToLower() == "mostrar")
            {
                byte[] data = HttpContext.Session.Get("PERSONAS");
                List<Persona> personas = (List<Persona>)HelperBinarySession.ByteToObject(data);
                return View(personas);
            }

            return View();
        }
    }
}
