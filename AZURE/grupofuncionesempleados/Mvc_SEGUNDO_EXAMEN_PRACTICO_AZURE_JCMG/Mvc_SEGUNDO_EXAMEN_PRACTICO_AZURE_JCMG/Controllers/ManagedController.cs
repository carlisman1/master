using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models;
using Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Services;
using System.Security.Claims;

namespace Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Controllers
{
    public class ManagedController : Controller
    {
        private ServiceCubos serviceCubos;

        public ManagedController(ServiceCubos serviceCubos)
        {
            this.serviceCubos = serviceCubos;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string pass)
        {
            string? token = await this.serviceCubos.GetTokenAsync(email, pass);
            if (token == null)
            {
                ViewData["MENSAJE"] = "Usuario/pass incorrectos";
            }
            else
            {
                ViewData["MENSAJE"] = "Bienvenido a mi App!!!";
                HttpContext.Session.SetString("TOKEN", token);
                ClaimsIdentity identity = new(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    ClaimTypes.Name,
                    ClaimTypes.Role);

                identity.AddClaim(new Claim(ClaimTypes.Name, email));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, pass.ToString()));

                ClaimsPrincipal userPrincipal = new(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    userPrincipal,
                    new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(30)
                    });
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("TOKEN");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult CrearUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearUsuario(int idusuario, string nombre, string email, string pass, string imagen)
        {
            await this.serviceCubos.InsertUsuario(idusuario, nombre, email, pass, imagen);
            return RedirectToAction("Index", "Home");
        }

    }
}
