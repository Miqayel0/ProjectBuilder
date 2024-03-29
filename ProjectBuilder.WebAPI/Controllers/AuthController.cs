﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectBuilder.Application.Dtos.Account;
using ProjectBuilder.Application.Dtos.Auth;
using ProjectBuilder.Application.Interfaces;

namespace ProjectBuilder.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ProfileDto>> Get()
        {
            var userId = User.Claims.Where(c => c.Type == "id").Select(c => c.Value).FirstOrDefault();
            return Ok(await _authService.GetProfile(userId));
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<ActionResult<LoginOutput>> Login([FromBody] LoginInput loginInput)
        {
            return Ok(await _authService.Login(loginInput));
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
