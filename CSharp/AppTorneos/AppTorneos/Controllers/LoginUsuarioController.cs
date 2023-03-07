using Microsoft.AspNetCore.Mvc;
using AppTorneos.Models;
using System.Text;
using AppTorneos.Repositories;

namespace AppTorneos.Controllers
{
    public class LoginUsuarioController : Controller
    {
        private RepositoryUsuarios repo;

        public LoginUsuarioController(RepositoryUsuarios repo)
        {
            this.repo = repo;
        }


        public IActionResult InicioPagina()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InicioPagina(string accion, string nombre, string usuariotag, string email, string contrasenia)
        {
            if (accion == "registro")
            {
                //AQUI HAZ EL REGISTRO
                ViewData["MENSAJE"] = "INIASTE REGISTRO";
                this.repo.InsertarUsuario(nombre, usuariotag, email, contrasenia);
            }else if (accion == "iniciosesion")
            {
                User usuario = this.repo.LoginUsuarios(email, contrasenia);
                if (usuario != null)
                {
                    //GUARDAR EN SESION
                    ViewData["MENSAJE"] = "INIASTE SESION";
                    //return a vista de menu de inicio
                }
                else
                {
                    ViewData["MENSAJE"] = "ERROR EN LAS CREDENCIALES";
                }
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
