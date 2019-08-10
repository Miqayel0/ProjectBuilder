using ProjectBuilder.Application.Dtos.Account;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Interfaces
{
    public interface IAccountService
    {
        Task<RegisterOutput> Register(RegisterInput input);
    }
}
