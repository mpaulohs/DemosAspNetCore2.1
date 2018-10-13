using Microsoft.AspNetCore.Mvc;

namespace demo21SignalR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}