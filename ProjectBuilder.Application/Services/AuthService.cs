using Microsoft.AspNetCore.Identity;
using ProjectBuilder.Application.Dtos.Auth;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.Domain.Entities;
using ProjectBuilder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IJwtFactory _jwtFactory;

        public AuthService(SignInManager<User> signInManager, IJwtFactory jwtFactory)
        {
            _signInManager = signInManager;
            _jwtFactory = jwtFactory;
        }
        public async Task<LoginOutput> Login(LoginInput loginInput)
        {
            var result = await _signInManager.PasswordSignInAsync(loginInput.UserName, loginInput.Password, false, false);

            if (!result.Succeeded)
            {
                throw new Exception();
            }

            var user = await _signInManager.UserManager.FindByNameAsync(loginInput.UserName);
            var roles = await _signInManager.UserManager.GetRolesAsync(user);

            var token = await _jwtFactory.GenerateEncodedToken(user.Id, user.UserName, roles);

            return new LoginOutput { AccessToken = token.AuthToken };
        }
    }
}
