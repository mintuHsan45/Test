using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreEvi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
