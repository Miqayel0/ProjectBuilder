using ProjectBuilder.Application.Dtos.Account;
using ProjectBuilder.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Services
{
    public class AccountService : IAccountService
    {
        public Task<RegisterOutput> Register(RegisterInput input)
        {
            throw new NotImplementedException();
        }
    }
}
