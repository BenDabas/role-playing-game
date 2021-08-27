using dotnet_rpg.Models;

namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
         Task<ServiceResponse<int>> Register(User user, string password);
    }
}