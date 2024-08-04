using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPT_DEMO.Services.CharacterServices
{
    public interface ICharacterServices
    {
        List<Character> GetAllCharacters();
        Character GetCharacterByID(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}