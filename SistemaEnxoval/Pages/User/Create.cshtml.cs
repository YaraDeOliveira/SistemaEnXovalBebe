using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaEnxoval.Context;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly SistemaEnxoval.Context.DataContext _context;

        public CreateModel(SistemaEnxoval.Context.DataContext context)
        {
            _context = context;
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
            if (!ModelState.IsValid || _context.Users == null || UserRepository == null)
            {
                return Page();
            }
            if(UserRepository.BirthForecast < DateTime.Today)
            {
                ModelState.AddModelError("UserRepository.BirthForecast", "Data prevista do nascimento não pode ser menor que a data de hoje!");
                return Page();
            }

            _context.Users.Add(UserRepository);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
