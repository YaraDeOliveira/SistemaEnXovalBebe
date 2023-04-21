using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Model;

namespace SistemaEnxoval.Pages.Portal
{
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;
        private SweetAlert _alertSweetAlert;

        public IndexModel(IUserService userService, SweetAlert alertSweetAlert)
        {
            _userService = userService;
            _alertSweetAlert = alertSweetAlert;
        }

        public IActionResult OnGet()
        {
            var isLogged = bool.Parse(HttpContext.Request.HttpContext.Session.GetString("UserLogged") ?? "false");
            if(!isLogged)
            {
                return RedirectToAction("Index","Home");
            }
            var userId = int.Parse(HttpContext.Request.HttpContext.Session.GetString("UserId"));
            _userService.IniciateItemsAsync(userId);
            return Page();
        }

    }
}
