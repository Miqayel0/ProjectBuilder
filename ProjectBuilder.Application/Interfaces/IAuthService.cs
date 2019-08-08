using ProjectBuilder.Application.Dtos.Auth;
using ProjectBuilder.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginOutput> Login(LoginInput loginInput);
    }
}
