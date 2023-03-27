using Microsoft.AspNetCore.Mvc;
using SistemaEnxoval.Interfaces;

namespace SistemaEnxoval.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
