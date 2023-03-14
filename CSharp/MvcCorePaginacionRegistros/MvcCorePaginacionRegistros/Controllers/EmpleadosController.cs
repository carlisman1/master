using Microsoft.AspNetCore.Mvc;
using MvcCorePaginacionRegistros.Repositories;

namespace MvcCorePaginacionRegistros.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult VistaEmpleados( int deptno)
        {
            return View(this.repo.GetEmpleadosOficioDept(deptno));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
