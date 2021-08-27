using System.Threading.Tasks;
using dotnet_rpg.Data;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
            private readonly IAuthRepository _authRepo;
            public AuthController(IAuthRepository authRepo)
            {
                _authRepo = authRepo;
            }

            public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
            {
                
            }


    }
}