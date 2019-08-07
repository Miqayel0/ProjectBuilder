using ProjectBuilder.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBuilder.Domain.Interfaces
{
    public interface IJwtFactory
    {
        Task<Token> GenerateEncodedToken(string id, string userName);
    }
}
