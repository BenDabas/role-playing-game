using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterConroller : ControllerBase
    {
        private static Character Knight = new Character();
        public IActionResult Get()
        {
            return Ok(Knight);
        }
    }
}