using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPT_DEMO.Services.CharacterServices
{
    public class CharacterService : ICharacterServices
    {
        private static List<Character> characters  = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
             return characters;
        }

        public Character GetCharacterByID(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            if(character is not null)
                return character;
            
            throw new Exception("Charater Not Found");
        }
    }
}