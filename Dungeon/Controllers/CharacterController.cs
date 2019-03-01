using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Dungeon.Data.Identity;
using Dungeon.Models.ViewModels;
using Dungeon.Services.Interfaces;
using GameLogic.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Dungeon.Controllers
{
    [Authorize]
    public class CharacterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICharacterService _characterService;

        public CharacterController(UserManager<AppUser> userManager, ICharacterService characterService)
        {
            _userManager = userManager;
            _characterService = characterService;
        }

        // Chreate character

        public IActionResult CreateCharacter()
        {
            var model = new CreateCharacterViewModel();
            model.FillRaceList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCharacter(CreateCharacterViewModel character)
        {
            if (ModelState.IsValid)
            {

            }

            throw new NotImplementedException();
        }


        // Edit character
    }
}