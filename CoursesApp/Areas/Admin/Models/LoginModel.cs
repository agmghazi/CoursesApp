using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoursesApp.Areas.Admin.Models
{
    public class LoginModel
    {
        [EmailAddress]
        [Required]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Message { get; set; }
    }
}