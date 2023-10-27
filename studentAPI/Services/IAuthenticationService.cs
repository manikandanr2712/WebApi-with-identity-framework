using System.IdentityModel.Tokens.Jwt;
using studentAPI.Models.Auth;

namespace studentAPI.Services
{
    public interface IAuthenticationService
    {
        Task<string> Register(RegisterRequest request);
        Task<string> Login(LoginRequest request);
    }
}
