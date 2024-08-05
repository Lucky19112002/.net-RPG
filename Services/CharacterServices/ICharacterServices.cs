using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace webAPT_DEMO.Services.CharacterServices
{
    public interface ICharacterServices
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterByID(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}