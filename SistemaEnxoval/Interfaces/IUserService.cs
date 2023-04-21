using SistemaEnxoval.Model;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Interfaces
{
    public interface IUserService
    {
        Task<bool> Create(UserRepository user);
        Task<bool> CheckEmail(string email);
        Task<UserRepository> Login(Login login);
        Task<UserRepository> GetById(int userId);
        Task<bool> HasItemsAsync(int userId);
        Task<IEnumerable<UserItemRepository>> SetItemsAsync(UserRepository user);
        Task<IEnumerable<UserItemRepository>> GetItemsAsync(UserRepository user);
    }
}
