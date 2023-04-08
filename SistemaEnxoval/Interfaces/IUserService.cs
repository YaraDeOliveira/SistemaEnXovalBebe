using SistemaEnxoval.Model;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Interfaces
{
    public interface IUserService
    {
        Task<bool> Create(UserRepository user);
        Task<bool> CheckEmail(string email);
        Task<bool> Login(Login login);
    }
}
