using Microsoft.AspNetCore.Mvc;
using MvcCoreAdoNet.Repositories;
using MvcCoreAdoNet.Models;


namespace MvcCoreAdoNet.Controllers
{
    public class DoctoresController : Controller
    {
        private RepositoryDoctor repo;

        public DoctoresController()
        {
            this.repo = new RepositoryDoctor();
        }

        public IActionResult Index()
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            return View(doctores);
        }

        [HttpPost]
        public IActionResult Index(string especialidad)
        {
            List<Doctor> doctores = this.repo.FindDoctor(especialidad);
            return View(doctores);
        }

        //public IActionResult DoctoresEspecialidad()
        //{
        //    List<Doctor> doctores = this.repo.GetDoctores();
        //    List<string> especialidades =
        //        this.repo.GetEspecialidades();
        //    DatosDoctores modelDatos = new DatosDoctores();
        //    modelDatos.Especialidades = especialidades;
        //    modelDatos.Doctores = doctores;
        //    return View(modelDatos);
        //}

        //[HttpPost]
        //public IActionResult DoctoresEspecialidad(string especialidad)
        //{
        //    List<Doctor> doctores =
        //        this.repo.FindDoctor(especialidad);
        //    List<string> especialidades =
        //        this.repo.GetEspecialidades();
        //    DatosDoctores model = new DatosDoctores();
        //    model.Doctores = doctores;
        //    model.Especialidades = especialidades;
        //    return View(model);
        //}

        public IActionResult DoctoresEspecialidad()
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            List<string> especialidades =
                this.repo.GetEspecialidades();
            ViewData["ESPECIALIDADES"] = especialidades;
            return View(doctores);
        }


        [HttpPost]
        public IActionResult DoctoresEspecialidad(string especialidad)
        {
            List<Doctor> doctores =
                this.repo.FindDoctor(especialidad);
            List<string> especialidades =
                this.repo.GetEspecialidades();
            ViewData["ESPECIALIDADES"] = especialidades;
            return View(doctores);
        }

        public IActionResult DoctoresHospital()
        {
            List<Hospital> nombres = 
                this.repo.GetHospitalesSelect();
            //NECESITAMOS LOS DOCTORES (TODOS)
            List<Doctor> doctores = this.repo.GetDoctores();
            //LOS HOSPITALES LOS ENVIAMOS POR VIEWDATA
            ViewData["NOMBRES"] = nombres;
            return View(doctores);
        }

    }
}
