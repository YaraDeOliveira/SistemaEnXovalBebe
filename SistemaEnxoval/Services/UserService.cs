using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Context;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _data;

        public UserService(DataContext data)
        {
            _data = data;
        }

        public async Task<bool> CheckEmail(string email)
        {
            try
            {
                var result = await _data.Users.FirstOrDefaultAsync(x => x.Email == email);
                if (result == null)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Create(UserRepository user)
        {
            try
            {
                _data.Users.Add(user);
                var result = await _data.SaveChangesAsync();
                if(result > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
