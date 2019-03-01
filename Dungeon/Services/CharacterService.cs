using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dungeon.Models;
using Dungeon.Services.Interfaces;

namespace Dungeon.Services
{
    public class CharacterService : ICharacterService
    {
        public async Task<Character> StoreCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public async Task<Character> UpdateCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
