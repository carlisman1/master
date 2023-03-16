using Microsoft.AspNetCore.Mvc;

namespace PruebaPaginadoMasPartial.ViewComponents
{
    public class ApartadoLogeadoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
