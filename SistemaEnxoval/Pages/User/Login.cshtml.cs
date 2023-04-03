using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaEnxoval.Repositories;
using SistemaEnxoval.Model;

namespace SistemaEnxoval.Pages.User
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Login { get; set; }


        public void OnGet()
        {
        }

    }
}
