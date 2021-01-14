﻿using Microsoft.AspNetCore.Identity;
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


        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
        Task<SignInResult> ValidatePasswordAsync(User user, string password);
    }
}
