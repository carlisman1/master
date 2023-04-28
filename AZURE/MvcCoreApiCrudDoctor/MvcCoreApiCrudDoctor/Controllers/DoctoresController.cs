using Microsoft.AspNetCore.Mvc;
using MvcCoreApiCrudDoctor.Models;
using MvcCoreApiCrudDoctor.Services;

namespace MvcCoreApiCrudDoctor.Controllers
{
    public class DoctoresController : Controller
    {
        private ServiceApiDoctor service;

        public DoctoresController(ServiceApiDoctor service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<Doctor> doc =
                await this.service.GetDoctoresAsync();
            return View(doc);
        }

        public async Task<IActionResult> Details(string iddoctor)
        {
            Doctor doc =
                await this.service.FindDoctorAsync(iddoctor);
            return View(doc);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Doctor doc)
        {
            await this.service.InsertDoctorAsync
                (doc.IdHospital, doc.IdDoctor, doc.Apellido
                , doc.Especialidad, doc.Salario);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string iddoctor)
        {
            Doctor doc =
                await this.service.FindDoctorAsync(iddoctor);
            return View(doc);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Doctor doc)
        {
            await this.service.UpdateDoctorAsync
                (doc.IdHospital, doc.IdDoctor, doc.Apellido
                , doc.Especialidad, doc.Salario);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string iddoctor)
        {
            await this.service.DeleteDoctorAsync(iddoctor);
            return RedirectToAction("Index");
        }

        public IActionResult Cliente()
        {
            return View();
        }
    }
}
