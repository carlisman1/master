using Microsoft.AspNetCore.Mvc;
using MvcLogicApp.Services;

namespace MvcLogicApp.Controllers
{
    public class LogicAppsController : Controller
    {
        private ServiceLogicApps service;

        public LogicAppsController(ServiceLogicApps service)
        {
            this.service = service;
        }



        public IActionResult Mail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Mail
            (string email, string asunto, string mensaje)
        {
            await this.service.SendMailAsync(email, asunto, mensaje);
            ViewData["MENSAJE"] = "Procesando Mail Logic Apps!!!";
            return View();
        }
    }
}
