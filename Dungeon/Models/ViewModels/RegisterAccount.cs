using System.ComponentModel.DataAnnotations;

namespace Dungeon.Models.ViewModels
{
    public class RegisterAccount
    {
        [Required(ErrorMessage = "Enter a username")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter an email")]
        //[DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm your email")]
        //[DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm email")]
        [Compare("Email", ErrorMessage = "Email doesn't match")]
        public string ConfirmEmail { get; set; }
    }
}
