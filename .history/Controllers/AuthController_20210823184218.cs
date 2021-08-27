using dotnet_rpg.Data;
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
    }
}