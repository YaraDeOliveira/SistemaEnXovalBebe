using System.ComponentModel.DataAnnotations;

namespace SistemaEnxoval.Model
{
    public class Login
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Senha")]
        [MinLength(3, ErrorMessage = "{0} deve conter no mínimo {1} letras!")]
        [MaxLength(8, ErrorMessage = "{0} deve conter no máximo {1} letras")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "{0} deve ser válido!")]
        public string Email { get; set; }
    }
}
