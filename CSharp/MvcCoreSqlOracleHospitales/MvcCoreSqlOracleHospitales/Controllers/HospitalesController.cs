using Microsoft.AspNetCore.Mvc;
using MvcCoreSqlOracleHospitales.Models;
using MvcCoreSqlOracleHospitales.Repositories;

namespace MvcCoreSqlOracleHospitales.Controllers
{
    public class HospitalesController : Controller
    {
        private IRepositoryHospital repo;

        public HospitalesController(IRepositoryHospital repo)
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
            Hospital hosp = this.repo.Detalles(idhospital);
            return View(hosp);
        }

        public IActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insertar(int idhospital, string nombre, string direccion, string telefono, int numCama)
        {
            this.repo.InsertarHospital(idhospital, nombre, direccion, telefono, numCama);
            return RedirectToAction("Index");
        }

        public IActionResult Modificar(int idhospital)
        {
            //BUSCAR EL HOSPITAL
            Hospital hosp = this.repo.Detalles(idhospital);
            return View(hosp);
        }
        [HttpPost]
        public IActionResult Modificar(int idhospital, string nombre, string direccion, string telefono, int numCama)
        {
            this.repo.ModificarHospital(idhospital, nombre, direccion, telefono, numCama);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int idhospital)
        {
            this.repo.EliminarHospital(idhospital);
            return RedirectToAction("Index");
        }
    }
}
