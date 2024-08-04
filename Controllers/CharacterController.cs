using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webAPT_DEMO.Controllers
{
    [ApiController]
    [Route("api/Character")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterServices _characterServices;

        public CharacterController(ICharacterServices characterServices)
        {
            this._characterServices = characterServices;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get(){
            return Ok(_characterServices.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id ){
            return Ok(_characterServices.GetCharacterByID(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            return Ok(_characterServices.AddCharacter(newCharacter));
        }
    }
}