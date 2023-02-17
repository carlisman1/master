using Microsoft.AspNetCore.Mvc;
using MvcCoreEnfermosEF.Repositories;
using MvcCoreEnfermosEF.Models;

namespace MvcCoreEnfermosEF.Controllers
{
    public class EnfermosController : Controller
    {
        private RepositoryEnfermo repo;

        public EnfermosController(RepositoryEnfermo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }

        public IActionResult Detalles(string inscripcion)
        {
            return View(this.repo.Detalles(inscripcion));
        }
    }
}
