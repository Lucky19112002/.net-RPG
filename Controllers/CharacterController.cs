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
        private static Character knight = new Character();
        [HttpGet]
        public ActionResult<Character> Get(){
            return Ok(knight);
        }
    }
}