using System.ComponentModel.DataAnnotations;

namespace SistemaEnxoval.Repositories
{
    public class UserRepository
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [Display(Name ="Nome")]
        [MinLength(5, ErrorMessage = "{0} deve conter no mínimo {1} letras!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "{0} é obrigatório!")]
        [Display(Name = "Senha")]
        [MinLength(3, ErrorMessage = "{0} deve conter no mínimo {1} letras!")]
        [MaxLength(8, ErrorMessage = "{0} deve conter no máximo {1} letras"!)]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório!")]
        [EmailAddress(ErrorMessage = "{0} deve ser valido!")]
        public string Email { get; set; }
        [Display(Name = "Nome do Bebê")]
        public string? BabyName { get; set; }

        [Display(Name = "Sexo do Bebê")]
        public char? BabyGender { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório!")]
        [Display(Name = "Data prevista do nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthForecast { get; set; }

        public UserRepository()
        {

        }
        public UserRepository(int id, string name, string password, string email, string? babyName, char? babyGender, DateTime birthForecast)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            BabyName = babyName;
            BabyGender = babyGender;
            BirthForecast = birthForecast;
        }
    }
}
