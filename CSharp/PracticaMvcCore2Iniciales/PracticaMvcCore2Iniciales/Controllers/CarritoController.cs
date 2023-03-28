using Microsoft.AspNetCore.Mvc;
using PracticaMvcCore2Iniciales.Extensions;
using PracticaMvcCore2Iniciales.Models;

namespace PracticaMvcCore2Iniciales.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult AñadeCarro(int idlibro)
        {
            List<Libros> libroscarro;
            if(HttpContext.Session.GetObject<List<Libros>>("Carro") != null)
            {
                libroscarro = new List<Libros>();
            }
            //libroscarro.Add(new Libros());
            return RedirectToAction("VistaLibros");
        }

        public IActionResult Carro()
        {
            return View();
        }
    }
}
