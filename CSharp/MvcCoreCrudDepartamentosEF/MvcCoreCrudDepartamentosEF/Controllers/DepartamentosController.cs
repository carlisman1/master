using Microsoft.AspNetCore.Mvc;
using MvcCoreCrudDepartamentosEF.Repositories;
using MvcCoreCrudDepartamentosEF.Models;

namespace MvcCoreCrudDepartamentosEF.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamento repo;

        public DepartamentosController(RepositoryDepartamento repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Departamento> depts = this.repo.GetDepartamentos();
            return View(depts);
        }

        public IActionResult Detalles(int iddepartamento)
        {
            return View(this.repo.FindDepartamento(iddepartamento));
        }

        public IActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insertar(string nombre, string localidad)
        {
            this.repo.InsertarDepartamento(nombre, localidad);
            return RedirectToAction("Index");
        }

        public IActionResult Modificar(int iddepartamento)
        {
            return View(this.repo.FindDepartamento(iddepartamento));
        }
        [HttpPost]
        public IActionResult Modificar(int iddepartamento, string nombre, string localidad)
        {
            this.repo.ModificarDepartamento(iddepartamento, nombre, localidad);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int iddepartamento)
        {
            this.repo.DeleteDepartamento(iddepartamento);
            return RedirectToAction("Index");
        }
    }
}
