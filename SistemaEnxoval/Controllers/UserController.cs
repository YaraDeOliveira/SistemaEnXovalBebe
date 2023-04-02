using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}
