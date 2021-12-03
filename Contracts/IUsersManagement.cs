using DAL.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    /// Interface for users, login and reset password
    /// </summary>
    public interface IUsersManagement
    {
        Task<User> Login(string userName, string password);
        Task<bool> ResetPassword(string userName, string newPassword);

        Task<IEnumerable<User>> GetUsers();
    }
}
