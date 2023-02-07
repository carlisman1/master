using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;


namespace PrimerMvcNetCore.Controllers
{   
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index(string variable1, string variable2)
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            ViewData["nombre"] = "Juan Carlso";
            ViewData["edad"] = 432;
            Persona persona = new Persona();
            persona.Nombre = "Persona Model";
            persona.Email = "modelo@gmail.com";
            persona.Edad = 99;
            return View(persona);
        }

        public IActionResult VistaControladorGet(string app, System.Nullable<int> version)
        {
            //CON ESTE METODO ME DEVUELVE EL VALOR O EL PRIMITIVO POR DEFECTO
            //version.GetValueOrDefault()

            //IMAGENES QUE LA VERSION ES OPCIONAL
            //A VECES LA RECIBIREMOS Y OTRAS NO
            if(version is null)
            {
                //ES OPCIONAL
                ViewData["DATOS"] = "Application: " + app + ", Version: " + version.GetValueOrDefault();
            }
            else
            {
                ViewData["DATOS"] = "Application: " + app + ", Version: " + version;
            }
            return View();
            
        }

        //ESTO ES EL METODO PARA EL GET QUE ES NECESARIO PARA 
        //POSTERIORMENTE HACER EL POST
        public IActionResult VistaControladorPost()
        {
            return View();
        }

        //METODO POST PARA POSTEAR LA INFO
        [HttpPost]
        public IActionResult
            VistaControladorPost(Persona persona, int inventado)
        {
            ViewData["DATOS"] = "Nombre: "
                + persona.Nombre
                + ", Email: "
                + persona.Email
                + ", Edad: "
                + persona.Edad
                +", Inventado: "
                + inventado;
            return View();
        }
    }
}
