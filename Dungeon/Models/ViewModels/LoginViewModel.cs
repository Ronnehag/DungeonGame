using System.ComponentModel.DataAnnotations;

namespace Dungeon.Models.ViewModels
{
    public class LoginViewModel
    {
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
