using Microsoft.AspNetCore.Mvc;
using PracticaMvcCore2Iniciales.Models;
using PracticaMvcCore2Iniciales.Repositories;
using System.Security.Claims;

namespace PracticaMvcCore2Iniciales.Controllers
{
    public class LibrosController : Controller
    {
        private RepositoryLibros repo;

        public LibrosController(RepositoryLibros repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> VistaLibros()
        {
            List<Libros> libros =
                await this.repo.GetLibrosAsync();
            return View(libros);
        }

        public async Task<IActionResult> Detalles(int idlibro)
        {
            Libros libro =
                await this.repo.DetallesLibro(idlibro);
            return View(libro);
        }

        public async Task<IActionResult> Filtrar(int idgenero, string nombregenero)
        {
            List<Libros> libro = await this.repo.FindLibroGenero(idgenero);
            ViewData["GENERO"] = nombregenero;
            return View(libro);
        }

        public async Task<IActionResult> PaginacionLibros(int? posicion)
        {
            int countLibros = await this.repo.LibrosCount();

            if(posicion == null)
            {
                posicion = 0;
            }

            if(posicion > countLibros)
            {
                posicion = 0;
            }

            if(posicion < 0)
            {
                posicion = countLibros - 1;
            }

            List<Libros> lib = await this.repo.PaginacionLibros(posicion.Value);

            ViewData["SIGUIENTE"] = posicion + 6;
            ViewData["ANTERIOR"] = posicion - 6;

            return View(lib);
        }
    }
}
