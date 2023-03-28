using Microsoft.AspNetCore.Mvc;
using PracticaMvcCore2Iniciales.Models;
using PracticaMvcCore2Iniciales.Repositories;

namespace PracticaMvcCore2Iniciales.Controllers
{
    public class GenerosController : Controller
    {
        private RepositoryGeneros repo;

        public GenerosController(RepositoryGeneros repo)
        {
            this.repo = repo;
        }

        //public async Task<List<Generos>> GetGenerosAsync()
        //{
        //    List<Generos> generos =
        //       await this.repo.GetGenerosAsync();
        //    return View(generos);
        //}
    }
}
