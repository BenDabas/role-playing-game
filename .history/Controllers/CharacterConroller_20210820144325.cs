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
            new Character{ Name: "Sam"}
        };
        
        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(Knight);
        }
    }
}