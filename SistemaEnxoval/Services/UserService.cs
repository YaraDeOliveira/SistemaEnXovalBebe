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
                if (result > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> HasItemsAsync(int userId)
        {
            try
            {
                return await _data.UserItems
                    .AsNoTracking()
                    .AnyAsync(x => x.User.Id == userId);
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

        public async Task<UserRepository> GetById(int userId)
        {
            try
            {
                return await _data.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == userId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<UserItemRepository>> SetItemsAsync(UserRepository user)
        {
            try
            {
                var items = await _data.Items
                    .AsNoTracking()
                    .ToListAsync();
                var insertItems = new List<UserItemRepository>();
                foreach (var item in items)
                {
                    insertItems.Add(new UserItemRepository()
                    {
                        ItemId = item.Id,
                        UserId = user.Id
                    });
                }
                _data.UserItems.AddRange(insertItems);
                await _data.SaveChangesAsync();
                return await GetItemsAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<UserItemRepository>> GetItemsAsync(UserRepository user)
        {
            try
            {
                var result = await _data.UserItems
                    .Include(x => x.Item)
                    .Include(x => x.User)
                    .AsNoTracking()
                    .Where(x => x.User == user)
                    .ToListAsync();

            return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ChangeStock(UserItemRepository userItem)
        {
            try
            {
                _data.UserItems.Update(userItem);
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

        public Task<UserItemRepository> GetUserItem(int id)
        {
            try
            {
                return _data.UserItems
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
