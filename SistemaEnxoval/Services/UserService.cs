using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Context;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Migrations;
using SistemaEnxoval.Model;
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

        public async Task IniciateItemsAsync(int userId)
        {
            try
            {
                var hasItems = await _data.UserItems.AnyAsync(x => x.User.Id == userId);
                if (hasItems) return;
                var items = await _data.Items.AsNoTracking().ToListAsync();
                var insertItems = new List<UserItemRepository>();
                var user = await _data.Users.FirstOrDefaultAsync(x => x.Id == userId);
                foreach (var item in items)
                {
                    insertItems.Add(new UserItemRepository()
                    {
                        Items= item,
                        User = user
                    });
                }
                _data.UserItems.AddRange(insertItems);
                await _data.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserRepository> Login(Login login)
        {
            var result = await _data.Users.FirstOrDefaultAsync(x => x.Email == login.Email && x.Password == login.Password);
            if (result != null)
            {
                return result;
            }
            return null;

        }
    }
}
