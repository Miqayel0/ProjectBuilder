using ProjectBuilder.Application.Dtos.Account;
using ProjectBuilder.Application.Dtos.Auth;
using System.Threading.Tasks;

namespace ProjectBuilder.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginOutput> Login(LoginInput loginInput);
    }
}
