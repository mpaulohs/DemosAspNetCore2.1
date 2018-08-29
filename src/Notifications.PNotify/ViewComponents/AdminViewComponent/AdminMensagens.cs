using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Notifications.PNotify.ViewComponents.AdminViewComponent
{ 
    public class AdminMensagens : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.FromResult<object>(null);
            return View();
        }
    }
}
