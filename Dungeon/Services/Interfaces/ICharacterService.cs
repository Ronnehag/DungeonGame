using System.Threading.Tasks;
using Dungeon.Models;

namespace Dungeon.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<Character> StoreCharacterAsync(Character character);
        Task<Character> UpdateCharacterAsync(Character character);
    }
}
