using Microsoft.AspNetCore.Mvc;
using PruebaPaginadoMasPartial.Models;
using PruebaPaginadoMasPartial.Repositories;

namespace PruebaPaginadoMasPartial.Controllers
{
    public class EmpleadoController : Controller
    {
        public RepositoryEmpleados repo;

        public EmpleadoController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index(int? posicion, int? paginacion, string oficio = "")
        {
            if(posicion == null)
            {
                posicion = 1;
            }

            if(paginacion == null)
            {
                paginacion = 5;
            }

            int numeroregistros = this.repo.GetEmpleadosOficio(oficio);
            ViewData["OFICIO"] = oficio;
            ViewData["REGISTROS"] = numeroregistros;
            ViewData["PAGINACION"] = paginacion;
            List<Empleado> empleados = this.repo.GetEmpleados(posicion.Value, paginacion.Value, oficio);

            return View(empleados);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int? posicion, int paginacion, string oficio="")
        {
            if (posicion == null)
            {
                posicion = 1;
            }

            int numeroregistros = this.repo.GetEmpleadosOficio(oficio);
            ViewData["OFICIO"] = oficio;
            ViewData["REGISTROS"] = numeroregistros;
            ViewData["PAGINACION"] = paginacion;
            List<Empleado> empleados = this.repo.GetEmpleados(posicion.Value, paginacion, oficio);

            return View(empleados);
        }

    }
}
