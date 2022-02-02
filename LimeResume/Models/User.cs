using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LimeResume.Models
{
    public partial class User : LoginModell
    {
        public int IdUser { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required(ErrorMessage = "Укажите почту для связи")]
        public string Email { get; set; }
    }
    
}
