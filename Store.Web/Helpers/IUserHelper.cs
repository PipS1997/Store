using Microsoft.AspNetCore.Identity;
using Store.Web.Data.Entities;
using Store.Web.Models;
using System.Threading.Tasks;

namespace Store.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);


        Task<IdentityResult> AddUserAsync(User user, string password);


        Task<SignInResult> LoginAsync(LoginViewModel model);

            Task LogoutAsync();

    }
}
