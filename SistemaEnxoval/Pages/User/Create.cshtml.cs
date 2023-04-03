using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Model;
using SistemaEnxoval.Repositories;
using SistemaEnxoval.Services;

namespace SistemaEnxoval.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly IUserService _userService;
        private SweetAlert _alertSweetAlert;

        public CreateModel(IUserService userService, SweetAlert alertSweetAlert)
        {
            _userService = userService;
            _alertSweetAlert = alertSweetAlert;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserRepository UserRepository { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid || UserRepository == null)
                {
                    return Page();
                }
                if (UserRepository.BirthForecast < DateTime.Today)
                {
                    ModelState.AddModelError("UserRepository.BirthForecast", "Data prevista do nascimento não pode ser menor que a data de hoje!");
                    return Page();
                }
                if (await _userService.CheckEmail(UserRepository.Email))
                {
                    _alertSweetAlert.Icon = "warning";
                    _alertSweetAlert.Show = true;
                    _alertSweetAlert.Text = "Email já cadastrado!";
                    _alertSweetAlert.Title = "Alerta";
                    ViewData["Swal"] = JsonConvert.SerializeObject(_alertSweetAlert);
                    return Page();
                }
                var result = await _userService.Create(UserRepository);
                if (result)
                {
                    _alertSweetAlert.Icon = "success";
                    _alertSweetAlert.Show = true;
                    _alertSweetAlert.Text = "";
                    _alertSweetAlert.Title = "Cadastrado com sucesso";
                    _alertSweetAlert.ActionPageRedirect = "Login";
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
