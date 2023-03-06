using Microsoft.AspNetCore.Mvc;
using MvcCoreUtilidades.Helpers;
using System.Net;
using System.Net.Mail;

namespace MvcCoreUtilidades.Controllers
{
    public class MailsController : Controller
    {
        private HelperUploadFiles helperUploadFiles;
        private HelperMail helperMail;

        public MailsController(HelperUploadFiles helperUploadFiles, HelperMail helperMail)
        {
            this.helperUploadFiles = helperUploadFiles;
            this.helperMail = helperMail;
        }

        public IActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMail
            (string para, string asunto, string mensaje, List<IFormFile> file)
        {
            List<string> paths = new List<string>();
            List<IFormFile> fileList = new List<IFormFile>();
            foreach (IFormFile f in file)
            {
                string path =
                    await this.helperUploadFiles.UploadFileAsync(f, Folders.Temporal);
                paths.Add(path);
            }
            if(file != null)
            {
                
                await this.helperMail.SendMailAsync(para, asunto, mensaje, paths);
            }
            else
            {
                await this.helperMail.SendMailAsync(para, asunto, mensaje);
            }

            ViewData["MENSAJE"] = "Email enviado correctamente";
            return View();
        }
    }
}
