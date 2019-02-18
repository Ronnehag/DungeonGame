
namespace Dungeon.Models.ViewModels
{
    public class RegisterAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
    }
}
