using Microsoft.AspNetCore.Mvc;
using MvcCoreUtilidades.Models;

namespace MvcCoreUtilidades.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> Cars;

        public CochesController()
        {
            this.Cars = new List<Coche>
            {
                new Coche {IdCoche = 1, Marca = "Pontiac"
                , Modelo = "Firebird", Imagen = ""},
                new Coche {IdCoche = 2, Marca = "VW"
                , Modelo = "Escarabajo", Imagen = ""},
                new Coche {IdCoche = 3, Marca = "Ferrari"
                , Modelo = "Testarrosa", Imagen = ""},
                new Coche {IdCoche = 4, Marca = "Ford"
                , Modelo = "Mustang GT", Imagen = ""},
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        //NECESITAMOS UNA PETICION PARA CADA VISAT ASINCRONA
        //QUE VAYAMOS A UTILIZAR
        //LOS METODOS PUEDEN LLAMARSE COMO QUERAMOS, ES DECIR,
        //DIFERENTES A LOS NOMBRES DE LAS VISTAS QUE UTILIZAN

        public IActionResult _CochesPartial()
        {
            //SI VAMOS A UTILIZAR UNA VISTA PARCIAL CON AJAX
            //DEBEMOS DEVOLVER PartialView
            //PartialView DEBE TENER EL NOMBRE DE LA VISTA PARCIAL
            //Y EL MODELO SI LO NECESITAMOS
            return PartialView("_CochesPartial", this.Cars);
        }

        public IActionResult Details(int idcoche)
        {
            Coche car = this.Cars.FirstOrDefault(c => c.IdCoche == idcoche);
            return View(car);
        }

        public IActionResult _DetailsCoche(int idcoche)
        {
            Coche car = this.Cars.FirstOrDefault(c => c.IdCoche == idcoche);
            return PartialView("_DetailsCoche", car);
        }

    }
}
