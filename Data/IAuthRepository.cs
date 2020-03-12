using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_API.Models;

namespace Shop_API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
        ClaimsPrincipal GetClaimsPrincipleFromExpiredToken(string token);
    }
}