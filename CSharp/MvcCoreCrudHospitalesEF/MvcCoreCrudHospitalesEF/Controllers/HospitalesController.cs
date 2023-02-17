using Microsoft.AspNetCore.Mvc;
using MvcCoreCrudHospitalesEF.Repositories;
using MvcCoreCrudHospitalesEF.Models;

namespace MvcCoreCrudHospitalesEF.Controllers
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

        public IActionResult Detalles(int hospitalCod)
        {
            return View(this.repo.FindHospital(hospitalCod));  
        }

        public IActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insertar(string nombre, string direccion, string telefono, int numCama)
        {
            this.repo.InsertarHospital(nombre, direccion, telefono, numCama);
            return RedirectToAction("Index");
        }

        public IActionResult Modificar(int hospitalCod)
        {
            return View(this.repo.FindHospital(hospitalCod));
        }
        [HttpPost]
        public IActionResult Modificar(int hospitalCod, string nombre, string direccion, string telefono, int numCama)
        {
            this.repo.ModificarHospital(hospitalCod, nombre, direccion, telefono, numCama);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int hospitalCod)
        {
            this.repo.EliminarHospital(hospitalCod);
            return RedirectToAction("Index");
        }
    }
}
