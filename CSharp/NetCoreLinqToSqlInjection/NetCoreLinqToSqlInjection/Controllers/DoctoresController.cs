using Microsoft.AspNetCore.Mvc;
using NetCoreLinqToSqlInjection.Repositories;
using NetCoreLinqToSqlInjection.Models;

namespace NetCoreLinqToSqlInjection.Controllers
{
    public class DoctoresController : Controller
    {
        private IRepository repo;

        public DoctoresController(IRepository repo) {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Doctor> Doctores = this.repo.GetDoctor();
            return View(Doctores);
        }

        public IActionResult Insertar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insertar(Doctor doc)
        {
            this.repo.InsertDoctor(doc.HospitalCod, doc.DoctorCod, doc.Apellido, doc.Especialidad, doc.Salario);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int iddoctor)
        {
            this.repo.DeleteDoctor(iddoctor);
            return RedirectToAction("Index");
        }
        
    }
}
