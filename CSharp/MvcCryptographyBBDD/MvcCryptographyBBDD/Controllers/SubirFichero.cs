using Microsoft.AspNetCore.Mvc;
using MvcCryptographyBBDD.Helpers;

namespace MvcCryptographyBBDD.Controllers
{
    public class SubirFichero : Controller
    {
        private HelperPathProvider helperPath;

        public SubirFichero(HelperPathProvider helperPath)
        {
            this.helperPath = helperPath;
        }

        public IActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile
            (IFormFile fichero)
        {
            //VAMOS A GUARDAR EL FICHERO EN UNA RUTA TEMPORAL(POR AHORA)
            //NECESITAMOS System.IO
            //string tempFolder = Path.GetTempPath();
            string host = "https://" + HttpContext.Request.Host.Value.ToString();
            string fileName = fichero.FileName;
            //NUESTRA RUTA SERA UNA COMBINACION DE LOS DOS
            //LAS RUTAS SIEMPRE SE ESCRIBEN CON Path.Combine
            //QUE SE ADAPTA A CADA SERVER CORE
            string path = this.helperPath.MapPath(fileName, Folders.Uploads);
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await fichero.CopyToAsync(stream);
            }
            ViewData["MENSAJE"] = "Fichero subido a " + path;
            ViewData["URL"] = "<a href='https://img.freepik.com/foto-gratis/bulldog-frances-marron-joven-jugando-aislado-pared-blanca-estudio_155003-31898.jpg'>Mi fichero</a>";
            return View();
        }
    }
}
