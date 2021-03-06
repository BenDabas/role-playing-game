using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterConroller : ControllerBase
    {
        private static Character Knight = new Character();
        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(Knight);
        }
    }
}