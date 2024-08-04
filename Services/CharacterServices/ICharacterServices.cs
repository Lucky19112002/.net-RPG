using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPT_DEMO.Services.CharacterServices
{
    public interface ICharacterServices
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterByID(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}