using Microsoft.AspNetCore.Mvc;
using MvcCoreEfProcedures.Models;
using MvcCoreEfProcedures.Repositories;

namespace MvcCoreEfProcedures.Controllers
{
    public class DoctoresController : Controller
    {
        private RepositoryDoctores repo;

        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            return View(doctores);
        }

        public IActionResult Especialidades()
        {
            List<string> espe = this.repo.GetEspecialidad();
            List<Doctor> doctores = this.repo.GetDoctores();
            ViewData["ESPECIALIDADES"] = espe;
            return View(doctores);
        }

        public IActionResult DoctoresEspecialidades(string especialidad)
        {
            List<Doctor> doctors = this.repo.GetDoctoresEspecialidades(especialidad);
            return View(doctors);
        }

        [HttpPost]
        public async Task<IActionResult> DoctoresEspecialidad(string especialidad, int incremento)
        {
            await this.repo.IncrementarSalarioAsync(especialidad, incremento);
            List<Doctor> doctores = this.repo.GetDoctores();
            List<string> especialidades = this.repo.GetEspecialidad();
            ViewData["ESPECIALIDADES"] = especialidades;
            return View(doctores);
        }

    }
}
