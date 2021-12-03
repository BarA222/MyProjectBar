using Contracts;
using DAL.Model;
using DAL.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// User service business logic class, implements the IUser
    /// </summary>
    public class UsersManagement : IUsersManagement
    {
        private UserRepository repo = new UserRepository();

        public async Task<IEnumerable<User>> GetUsers()
        {
            var result = await repo.GetUsers();
            return result;
        }

        public async Task<User> Login(string userName, string password)
        {
            var result = await repo.LoginAsync(userName, password);
            
           
            return result;
        }

        public async Task<bool> ResetPassword(string userName, string newPassword)
        {
            return await repo.ResetPasswordAsync(userName, newPassword);
        }

    }
}
