using DAL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepository
    {
        ConsultantsManagementDbContext dbContext = new ConsultantsManagementDbContext();
        public string CheckUserName(string userName)
        {

            var result = dbContext.Users.Where(x => x.UserName == userName)
                .Select(u => u.UserName).SingleOrDefault();


            return result;
        }
        public string CheckPassword(string password)
        {

            var result = dbContext.Users.Where(x => x.Password == password)
                .Select(u => u.Password).SingleOrDefault();

            return result;
        }
        public void ResetPassword(string userName, string newPassword)
        {
            var user = dbContext.Users.Where(x => x.UserName == userName)
                .SingleOrDefault();

            user.Password = newPassword;

            dbContext.SaveChanges();

        }
    }
}
