using System.ComponentModel.DataAnnotations;

namespace LimeResume.Models
{
    public class LoginModell
    {
        [Required(ErrorMessage = "Введите логин")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
    }
}
