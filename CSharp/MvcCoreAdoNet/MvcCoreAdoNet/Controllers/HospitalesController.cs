using Microsoft.AspNetCore.Mvc;
using MvcCoreAdoNet.Repositories;
using MvcCoreAdoNet.Models;


namespace MvcCoreAdoNet.Controllers
{
    public class HospitalesController : Controller
    {
        private RepositryHospital repo;

        public HospitalesController()
        {
            this.repo = new RepositryHospital();
        }

        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            return View(hospitales);
        }

        public IActionResult Detalles(int idhospital)
        {
            Hospital hospital = this.repo.FindHospital(idhospital);
            return View(hospital);
        }
    }
}
