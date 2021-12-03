using DAL.DataAccess;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// This class allows users to login or reset their password
    /// </summary>
    public class UserRepository
    {
        ConsultantsManagementDbContext dbContext = new ConsultantsManagementDbContext();

        public async Task<User> LoginAsync(string userName, string password)
        {
            try
            {
                var result = await dbContext.Users
           .Where(x => x.UserName == userName && x.Password == password)
           .FirstOrDefaultAsync();

                return result;
            }
            catch
            {
                return null;
            }

        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            try
            {
                var result = await dbContext.Users.ToListAsync();

                return result;
            }
            catch
            {
                return new List<User>();
            }

        }
        public async Task<bool> ResetPasswordAsync(string userName, string newPassword)
        {
            try
            {
                var user = await dbContext.Users
                .Where(x => x.UserName == userName)
                .SingleOrDefaultAsync();

                if (user == null)
                    return false;

                if (string.IsNullOrEmpty(newPassword))
                    return false;

                user.UpdatePassword(newPassword);

                await dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
