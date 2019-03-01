using Dungeon.Data.Identity;
using Dungeon.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Dungeon.Controllers
{
    public class CharacterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICharacterService _characterService;

        public CharacterController(UserManager<AppUser> userManager, ICharacterService characterService)
        {
            _userManager = userManager;
            _characterService = characterService;
        }


        // Edit character
    }
}