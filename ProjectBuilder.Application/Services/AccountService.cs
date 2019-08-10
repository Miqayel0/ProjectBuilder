using Microsoft.AspNetCore.Identity;
using ProjectBuilder.Application.Dtos.Account;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;

        public AccountService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<RegisterOutput> Register(RegisterInput input)
        {
            var newUser = new User
            {
                UserName = input.UserName,
                Email = input.Email,
                Name = input.Name,
                Surname = input.Surname,
            };

            var result = await _userManager.CreateAsync(newUser, input.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);
                var joinedErrors = string.Join(Environment.NewLine, errors);

                throw new Exception(joinedErrors);
            }

            // Add all new users to the User role
            await _userManager.AddToRoleAsync(newUser, "User");

            // Add new users whose email starts with 'admin' to the Admin role
            if (newUser.Email.StartsWith("admin"))
            {
                await _userManager.AddToRoleAsync(newUser, "Admin");
            }

            return new RegisterOutput { CanLogin = true };
        }

    }
}
