using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            ServiceResponse  = new ServiceResponse<characters>
            return response;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}