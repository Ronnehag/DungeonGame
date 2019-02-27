using System.ComponentModel.DataAnnotations;

namespace Dungeon.Models.ViewModels
{
    public class AccountDetailsViewModel
    {

        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="Current password")]
        [Required]
        public string CurrentPassword { get; set; }

        [Display(Name = "New password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name = "Confirm new password")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }

        [Display(Name = "Current email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string CurrentEmail { get; set; }

        [Display(Name = "Change email")]
        [DataType(DataType.EmailAddress)]
        public string NewEmail { get; set; }


    }
}
