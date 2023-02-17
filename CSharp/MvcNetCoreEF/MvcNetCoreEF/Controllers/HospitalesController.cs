using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEF.Repositories;
using MvcNetCoreEF.Models;

namespace MvcNetCoreEF.Controllers
{
    public class HospitalesController : Controller
    {
        private RepositoryHospital repo;

        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            return View(hospitales);
        }

        public IActionResult Detalles(int idhospital)
        {
            return View(this.repo.Detalles(idhospital));
        }

        //public IActionResult Insertar()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Insertar(int idhospital, string nombre, string direccion, string telefono, int camas)
        //{
        //    this.repo.InsertarHospital(idhospital, nombre, direccion, telefono, camas);
        //    return RedirectToAction("Index");
        //}
    }
}
