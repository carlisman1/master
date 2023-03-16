using Microsoft.AspNetCore.Mvc;
using PruebaPaginadoMasPartial.Extensions;
using PruebaPaginadoMasPartial.Models;
using PruebaPaginadoMasPartial.Repositories;
using System.Diagnostics;

namespace PruebaPaginadoMasPartial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RepositoryEmpleados repo;

        public HomeController(ILogger<HomeController> logger, RepositoryEmpleados repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string apellido, string oficio)
        {
            Empleado emp = this.repo.HacerLogin(apellido, oficio);

            if (emp == null)
            {
                ViewData["ERROR"] = "bLA";
                return View();
            }
            else
            {
                HttpContext.Session.SetObject("EMP", emp);
                ViewData["CONECTADO"] = "Estas conectado";
                return View();
                /*return RedirectToAction("ConsultaPaginado","Usuarios");*/
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}