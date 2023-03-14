using Microsoft.AspNetCore.Mvc;
using MvcCorePaginacionRegistros.Models;
using MvcCorePaginacionRegistros.Repositories;

namespace MvcCorePaginacionRegistros.ViewComponents
{
    public class DepartamentosViewComponent : ViewComponent
    {
        //POR SUPUESTO, PODEMOS UTILIZAR INYECCION
        private RepositoryDepartamentos repo;

        public DepartamentosViewComponent(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        //AQUI PODRIAMOS TENER CUALQUIER METODO DE UNA CLASE
        //LA PETICION SE REALIZA MEDIANTE EL METODO InvokeAsync
        //ES OBLIGATORIO TENERLO
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Departamento> depts = this.repo.GetDepts();
            return View(depts);
        }
    }
}
