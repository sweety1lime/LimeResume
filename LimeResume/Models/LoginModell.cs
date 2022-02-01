using System.ComponentModel.DataAnnotations;

namespace LimeResume.Models
{
    public class LoginModell
    {
        [Required(ErrorMessage = "Не указан Логин")]
        public string login { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
