using Microsoft.AspNetCore.Mvc;
using MvcCoreAdoNet.Repositories;
using MvcCoreAdoNet.Models;


namespace MvcCoreAdoNet.Controllers
{
    public class HospitalesController : Controller
    {
        private RepositoryHospital repo;

        public HospitalesController()
        {
            this.repo = new RepositoryHospital();
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

        public IActionResult CreateHospital()
        {
            return View();
        }

        //CUANDO PULSEMOS EL BOTON, QUE DEBEMOS RECIBIR???
        //MEJOR RECIBIR UN MODEL BINDING
        [HttpPost]
        public IActionResult CreateHospital(Hospital hospital)
        {
                this.repo.CreateHospital(hospital.IdHospital, hospital.Nombre, hospital.Direccion
                ,hospital.Telefono, hospital.Camas);
            ViewData["MENSAJE"] = "Hospital creado!";
            return View();
        }
    }
}
