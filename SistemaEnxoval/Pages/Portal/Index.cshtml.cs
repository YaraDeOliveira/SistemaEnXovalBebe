using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Model;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Pages.Portal
{
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;
        private SweetAlert _alertSweetAlert;
        bool _islogged = false;
        int _userId = 0;
        public IEnumerable<UserItemRepository> listItems = null;

        public IndexModel(IUserService userService, SweetAlert alertSweetAlert)
        {
            _userService = userService;
            _alertSweetAlert = alertSweetAlert;
        }

        public async Task<IActionResult> OnGet()
        {
            _userId = int.Parse(HttpContext.Request.HttpContext.Session.GetString("UserId") ?? "0");
            _islogged = bool.Parse(HttpContext.Request.HttpContext.Session.GetString("UserLogged") ?? "false");
            if (!_islogged && _userId == 0)
            {
                return RedirectToAction("Index","Home");
            }
            var user = await _userService.GetById(_userId);
            listItems = await _userService.GetItemsAsync(user); ;
            if(listItems.Count() <= 0)
            {
                listItems = await _userService.SetItemsAsync(user);
            }
            return Page();
        }

    }
}
