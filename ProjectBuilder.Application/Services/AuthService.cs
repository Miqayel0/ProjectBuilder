﻿using Microsoft.AspNetCore.Identity;
using ProjectBuilder.Application.Dtos.Account;
using ProjectBuilder.Application.Dtos.Auth;
using ProjectBuilder.Application.Interfaces;
using ProjectBuilder.Domain.Entities;
using ProjectBuilder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly IJwtFactory _jwtFactory;
        public AuthService(UserManager<User> userManager, IJwtFactory jwtFactory)
        {
            _userManager = userManager;
            _jwtFactory = jwtFactory;
        }

        public async Task<ProfileDto> GetProfile(string input)
        {
            var user = await _userManager.FindByIdAsync(input);

            if (user == null)
            {
                throw new Exception("User dose not exist");
            }

            var roles = await _userManager.GetRolesAsync(user);

            return new ProfileDto
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                IconUrl = user.IconUrl,
                Roles = roles,
            };
        }

        public async Task<LoginOutput> Login(LoginInput loginInput)
        {
            if (string.IsNullOrWhiteSpace(loginInput.Password) || string.IsNullOrWhiteSpace(loginInput.UserName))
            {
                throw new Exception("Invalid UserName or Password");
            }

            var user = await _userManager.FindByNameAsync(loginInput.UserName);

            if (user == null || !await _userManager.CheckPasswordAsync(user, loginInput.Password))
            {
                throw new Exception("Invalid UserName or Password");
            }

            var roles = await _userManager.GetRolesAsync(user);

            var token = await _jwtFactory.GenerateEncodedToken(user.Id, user.UserName, roles);
            var profile = await GetProfile(user.Id);

            return new LoginOutput { AccessToken = token.AuthToken, Account = profile };
        }
    }
}
