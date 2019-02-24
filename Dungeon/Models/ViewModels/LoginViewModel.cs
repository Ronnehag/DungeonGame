using System.ComponentModel.DataAnnotations;

namespace Dungeon.Models.ViewModels
{
    public class LoginViewModel
    {
        [DataType(DataType.Text)]
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
