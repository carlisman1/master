using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PracticaMvcCore2Iniciales.Filters;
using PracticaMvcCore2Iniciales.Models;
using PracticaMvcCore2Iniciales.Repositories;
using System.Security.Claims;

namespace PracticaMvcCore2Iniciales.Controllers
{
    public class UsuariosController : Controller
    {
        private RepositoryUsuarios repo;

        public UsuariosController(RepositoryUsuarios repo)
        {
            this.repo = repo;
        }

        [AuthorizeUsuarios]
        public async Task<IActionResult> Perfil()
        {
            string data = HttpContext.User.FindFirst("IdUsuario").Value;
            int iduser = int.Parse(data);
            Usuarios user = await this.repo.FindUsuarioAsync(iduser);
            return View(user);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string pass)
        {
            Usuarios user = this.repo.GetUserByEmailPass(email, pass);
            if (user != null)
            {
                ClaimsIdentity identity =
                    new ClaimsIdentity
                    (CookieAuthenticationDefaults.AuthenticationScheme,
                    ClaimTypes.Name, ClaimTypes.Role);

                Claim claimEmail = new Claim(ClaimTypes.Email, user.Email);
                identity.AddClaim(claimEmail);

                Claim claimID =
                    new Claim("IdUsuario", user.IdUsuario.ToString());
                identity.AddClaim(claimID);

                ClaimsPrincipal userPrincipal =
                    new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync
                    (CookieAuthenticationDefaults.AuthenticationScheme
                    , userPrincipal);

                return RedirectToAction("Perfil", "Usuarios");
            }
            else
            {
                ViewData["MENSAJE"] = "Usuario/Password incorrectos";
                return View();
            }
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync
            (CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
