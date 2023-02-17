using Microsoft.AspNetCore.Mvc;
using SegundaPracticaJaunCarlosMarañon.Models;
using SegundaPracticaJaunCarlosMarañon.Repositories;

namespace SegundaPracticaJaunCarlosMarañon.Controllers
{
    public class ComicController : Controller
    {
        private IRepositoryComic repo;

        public ComicController(IRepositoryComic repo)
        {
            this.repo = repo;
        }   

        public IActionResult Index()
        {
            List<Comic> com = this.repo.GetComics();
            return View(com);
        }

        public IActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insertar(int idcomic, string nombre, string imagen, string descripcion)
        {
            this.repo.InsertarComic(idcomic, nombre, imagen, descripcion);
            return RedirectToAction("Index");
        }
    }
}
