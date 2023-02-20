using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEF.Repositories;
using MvcNetCoreEF.Models;

namespace MvcNetCoreEF.Controllers
{
    public class EmpleadosController : Controller
    {
        public RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }



        public IActionResult IncrementoSalarial()
        {
            List<string> oficios = this.repo.GetOficios();
            ViewData["OFICIOS"] = oficios;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IncrementoSalarial
            (int incremento, string oficio)
        {
            ModelEmpleado model = 
                await this.repo.IncrementarSalariosAsync(incremento, oficio);
            List<string> oficios = this.repo.GetOficios();
            ViewData["OFICIOS"] = oficios;
            return View(model);
        }
    }
}
