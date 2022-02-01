using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LimeResume.Models
{
    public partial class User : LoginModell
    {
        public int IdUser { get; set; }
        [Required(ErrorMessage = "Введите логин")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Укажите почту для связи")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
        [Compare("password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get; set; }
    }
}
