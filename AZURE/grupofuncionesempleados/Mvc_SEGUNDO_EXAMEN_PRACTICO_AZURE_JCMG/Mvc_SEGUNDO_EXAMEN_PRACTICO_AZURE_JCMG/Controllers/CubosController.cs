using Microsoft.AspNetCore.Mvc;
using Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Filters;
using Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models;
using Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Services;

namespace Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Controllers
{
    public class CubosController : Controller
    {
        private ServiceCubos service;

        public CubosController(ServiceCubos service)
        {
            this.service = service;
        }
        
        public async Task<IActionResult> Index()
        {
            List<Cubo> cub =            
                await this.service.GetCubosAsync();

            return View(cub);
        }

        public async Task<IActionResult> FindCubo(string marca)
        {
            List<Cubo> cub =
                await this.service.FindCubo(marca);
            return View("Index",cub);
        }

        [AuthorizeUsuarios]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCubo cub)
        {
            await this.service.InsertCubo(cub.IdCubo, cub.Nombre, cub.Marca, cub.Imagen, cub.Precio);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Perfil(UsuarioCubos usu)
        {
            await this.service.PerfilUsuario(usu);
            return View();
        }
    }
}
