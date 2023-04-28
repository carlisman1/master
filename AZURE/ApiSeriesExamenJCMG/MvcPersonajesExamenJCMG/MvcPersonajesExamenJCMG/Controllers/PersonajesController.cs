using Microsoft.AspNetCore.Mvc;
using MvcPersonajesExamenJCMG.Models;
using MvcPersonajesExamenJCMG.Services;

namespace MvcPersonajesExamenJCMG.Controllers
{
    public class PersonajesController : Controller
    {
        private ServiceApiPersonajes service;

        public PersonajesController(ServiceApiPersonajes service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<Personaje> per =
                await this.service.GetPersonajeAsync();
            return View(per);
        }

        public async Task<IActionResult> Details(int idpersonaje)
        {
            Personaje per =
                await this.service.FindPersonajeAsync(idpersonaje);
            return View(per);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Personaje per)
        {
            await this.service.InsertPersonajeAsync
                (per.IdPersonaje, per.NPersonaje, per.Imagen, per.IdSerie);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int idpersonaje)
        {
            Personaje per =
                await this.service.FindPersonajeAsync(idpersonaje);
            return View(per);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Personaje per)
        {
            await this.service.UpdatePersonajeAsync
                (per.IdPersonaje, per.NPersonaje, per.Imagen, per.IdSerie);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int idpersonaje)
        {
            await this.service.DeletePersonajeAsync(idpersonaje);
            return RedirectToAction("Index");
        }

        public IActionResult Cliente()
        {
            return View();
        }
    }
}
