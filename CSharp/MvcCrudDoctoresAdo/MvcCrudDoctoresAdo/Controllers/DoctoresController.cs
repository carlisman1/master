using Microsoft.AspNetCore.Mvc;
using MvcCrudDoctoresAdo.Models;
using MvcCrudDoctoresAdo.Repositories;

namespace MvcCrudDoctoresAdo.Controllers
{
    public class DoctoresController : Controller
    {

        private RepositoryDoctores repo;

        public DoctoresController()
        {
            repo = new RepositoryDoctores();
        }

        public IActionResult Index()
        {
            List<Doctor> doctores =
               this.repo.GetDoctores();
            return View(doctores);
        }

        public IActionResult Create()
        {
            ViewData["LISTAHOSPITALES"] = this.repo.GetHospitales();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            this.repo.Create(doctor.IdHospital, doctor.IdDoctor, doctor.Apellido
                , doctor.Especialidad, doctor.Salario);
            return RedirectToAction("Index");
        }

        public IActionResult Detalles(int iddoctor)
        {
            return View(this.repo.Detalles(iddoctor));
        }

        public IActionResult Modificar(int iddoc)
        {
            return View(this.repo.Detalles(iddoc));
        }
        [HttpPost]
        public IActionResult Modificar(Doctor doctor)
        {
            this.repo.Modificar(doctor.IdHospital, doctor.IdDoctor
                , doctor.Apellido, doctor.Especialidad, doctor.Salario);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int iddoctor)
        {
            this.repo.Eliminar(iddoctor);
            return RedirectToAction("Index");
        }

        //public IActionResult GetHospitales()
        //{
        //    //Hospital h = new Hospital();
        //    //h.IdHospital = 99;
        //    //h.Nombre = "Nuevo";
        //    //ViewData["HOSPITAL"] = h;
        //    //Hospital hospital = ViewData["HOSPITAL"] as Hospital;
            


        //    return View();
        //}
    }
}
