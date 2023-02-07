using Microsoft.AspNetCore.Mvc;
using MvcCoreEmpty.Models;

namespace MvcCoreEmpty.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult VistaPersona()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno Core";
            persona.Email = "klk@klk.klk";
            persona.Edad = 28;
            return View(persona);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contenido()
        {
            return View();
        }
    }
}
