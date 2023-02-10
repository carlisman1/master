using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentosAdo.Repositories;
using MvcCrudDepartamentosAdo.Models;

namespace MvcCrudDepartamentosAdo.Controllers
{
    public class DepartamentosController : Controller
    {

        private RepositoryDepartamentos repo;

        public DepartamentosController()
        {
            repo = new RepositoryDepartamentos();
        }

        public IActionResult Index()
        {
            List<Departamento> departamentos =
                this.repo.GetDepartamentos();
            return View(departamentos);
        }

        public IActionResult Detalles (int iddepartamento)
        {
            Departamento departamento =
                this.repo.FindDepartamento(iddepartamento);
            return View(departamento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (Departamento departamento)
        {
            this.repo.CreateDepartamento(departamento.IdDepartamento
            , departamento.Nombre, departamento.Localidad);
            ViewData["MENSAJE"] = "Departamento insertado";
            //return View("Index");
            //EXISTE UN METODO LLAMADO RedirectToAction
            //QUE NO MANDA UNA VISTA, SINO QUE MANDA AL ACTION
            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int iddepartamento)
        {
            this.repo.DeleteDepartamento(iddepartamento);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int iddepartamento)
        {
            Departamento departamento = this.repo.FindDepartamento(iddepartamento);
            //ViewData["MENSAJE"] = "DEPARTAMENTO MODIFICADO";
            return View(departamento);
        }
        [HttpPost]
        public IActionResult Update(Departamento departamento)
        {
            this.repo.UpdateDepartamento(departamento.IdDepartamento,
                departamento.Nombre, departamento.Localidad);
            return RedirectToAction("Index");
        }
    }
}
