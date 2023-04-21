using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaEnxoval.Repositories;
using SistemaEnxoval.Model;
using SistemaEnxoval.Interfaces;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace SistemaEnxoval.Pages.User
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;
        private SweetAlert _alertSweetAlert;

        [BindProperty]
        public Login Login { get; set; }

        public LoginModel(IUserService userService, SweetAlert alertSweetAlert)
        {
            _userService = userService;
            _alertSweetAlert = alertSweetAlert;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid || Login == null)
                {
                    return Page();
                }
                var result = await _userService.Login(Login);
                if (result != null)
                {
                    _alertSweetAlert.Show = true;
                    _alertSweetAlert.Text = "Acessando sua conta";
                    _alertSweetAlert.Icon = "success";
                    _alertSweetAlert.Title = "Login";
                    ViewData["Swal"] = JsonConvert.SerializeObject(_alertSweetAlert);
                    HttpContext.Request.HttpContext.Session.SetString("UserName",result.Name);
                    HttpContext.Request.HttpContext.Session.SetString("UserId",result.Id.ToString());
                    HttpContext.Request.HttpContext.Session.SetString("UserLogged","true");
                    return RedirectToAction("Index", "Portal");
                }
                else
                {
                    _alertSweetAlert.Show = true;
                    _alertSweetAlert.Text = "Verifique se o email e senha estão digitados corretamente";
                    _alertSweetAlert.Icon = "warning";
                    _alertSweetAlert.Title = "Login";
                }
            }
            catch (Exception ex)
            {
                _alertSweetAlert.Icon = "error";
                _alertSweetAlert.Show = true;
                _alertSweetAlert.Text = ex.Message;
                _alertSweetAlert.Title = "Alerta";
            }
            ViewData["Swal"] = JsonConvert.SerializeObject(_alertSweetAlert);
            return Page();
        }
    }

}

