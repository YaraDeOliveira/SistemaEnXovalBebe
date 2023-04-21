using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Model;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Controllers
{
    public class UserController : Controller
    {
        private Login _login;

        public UserController(Login login)
        {
            _login = login;
        }

        public IActionResult Logout()
        {
            HttpContext.Request.HttpContext.Session.Remove("UserName");
            HttpContext.Request.HttpContext.Session.Remove("UserId");
            HttpContext.Request.HttpContext.Session.SetString("UserLogged","false");
            return RedirectToPage("/Index","Pages");
        }

    }
}
