using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Model;
using SistemaEnxoval.Repositories;

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
            return RedirectToPage("/Index","Pages");
        }

        [HttpGet]
        public IActionResult ChangeStock([FromQuery] int id, int stock)
        {
            var item = _userService.GetUserItem(id).Result;
            if(item == null){
                return NotFound();
            }
            item.Stock = stock;
            var result = _userService.ChangeStock(item).Result;
            return Ok(result);
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
