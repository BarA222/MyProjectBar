using Contracts;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class UsersManagement : IUsersManagement
    {
        private UserRepository repo = new UserRepository();
        public void Login(string userName, string password)
        {
            var resultPassword = repo.CheckPassword(password);
            var resultName = repo.CheckUserName(userName);

            if (resultName == "consultant" && resultPassword == "1111")
            {
                Console.WriteLine("Logged in");

            }
            if (resultName == "admin" && resultPassword == "1234")
            {
                Console.WriteLine("Logged in");

            }
            else
            {
                Console.WriteLine($"UserName or password is incorrect");
            }
        }

        public void ResetMyPassword(string userName, string newPassword)
        {
            var resultName = repo.CheckUserName(userName);

            if (resultName == "consultant" || resultName == "admin")
            {
                repo.ResetPassword(userName, newPassword);
                Console.WriteLine($"Password has been changed successfully");
            }
            else
            {
                Console.WriteLine($"UserName is not exist, please enter existing userName");
            }
        }

    }
}
