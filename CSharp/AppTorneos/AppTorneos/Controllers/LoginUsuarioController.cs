using Microsoft.AspNetCore.Mvc;
using AppTorneos.Models;
using System.Text;

namespace AppTorneos.Controllers
{
    public class LoginUsuarioController : Controller
    {
        public IActionResult InicioPagina()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InicioPagina(string accion, string nombre, string usuario, string email)
        {
            if (accion == "registro")
            {
                //AQUI HAZ EL REGISTRO
            }else if (accion == "iniciosesion")
            {
                //AQUI EL INICIO DE SESION

                //SI COINCIDE EL USUARIO, GUARDA EN SESION Y REDIRIGE SIGUIENTE VISTA
                //SI NO DEVUELVELE A LA VISTA CON ERROR
            }
            return View();
        }

        public IActionResult SessionPersonaJson(string? accion)
        {
            if(accion == null)
            {
                return View();
            }

            if(accion.ToLower() == "almacenar")
            {
                User usu = new()
                {
                    
                };
            }
            return View();
        }
    }
}
