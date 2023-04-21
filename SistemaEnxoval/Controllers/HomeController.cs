using Microsoft.AspNetCore.Mvc;

namespace SistemaEnxoval.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
