using System.ComponentModel.DataAnnotations;

namespace SistemaEnxoval.Models
{
    public class UserRepository
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nome")]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string? BabyName { get; set; }
        public char? BabyGender { get; set; }
        [Required]
        
        public DateTime BirthForecast { get; set; }

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
