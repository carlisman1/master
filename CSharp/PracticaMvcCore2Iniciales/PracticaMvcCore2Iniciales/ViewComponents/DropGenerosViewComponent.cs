using Microsoft.AspNetCore.Mvc;
using PracticaMvcCore2Iniciales.Models;
using PracticaMvcCore2Iniciales.Repositories;

namespace PracticaMvcCore2Iniciales.ViewComponents
{
    public class DropGenerosViewComponent: ViewComponent
    {
        private RepositoryGeneros repo;

        public DropGenerosViewComponent(RepositoryGeneros repo)
        {
            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Generos> generos = await this.repo.GetGenerosAsync();
            return View(generos);
        }
    }
}


