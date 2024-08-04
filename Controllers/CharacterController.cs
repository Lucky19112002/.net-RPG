global using webAPT_DEMO.Models;
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
        private static List<Character> characters  = new List<Character> {
            new Character(),
            new Character { Name = "Sam"}
        };
        
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get(){
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle(){
            return Ok(characters[0]);
        }
    }
}