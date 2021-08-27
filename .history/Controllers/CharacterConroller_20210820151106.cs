using System.Collections.Generic;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterConroller : ControllerBase
    {
        // private static Character Knight = new Character(); // return one character.
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Name = "Sam"}
        };
        
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle() 
        {
            return Ok(characters);
        }
    }
}