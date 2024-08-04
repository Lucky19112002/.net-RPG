using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPT_DEMO.Services.CharacterServices
{
    public interface ICharacterServices
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterByID(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}