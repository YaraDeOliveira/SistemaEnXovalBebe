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

        public void Create(UserRepository user)
        {
            try
            {
                _data.Add(user);
                _data.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
