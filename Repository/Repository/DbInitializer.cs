using DAL.DataAccess;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// Class for the first run of the progrem
    /// Add users, customers and meetings data
    /// </summary>
    public class DbInitializer
    {
        ConsultantsManagementDbContext dbContext;

        public DbInitializer()
        {
            dbContext = new ConsultantsManagementDbContext();
        }

        public async Task Initializer()
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    UserName = "admin",
                    Password = "1234",
                    UserType = UserType.Admin
                },
                new User()
                {
                    UserName = "consultant",
                    Password = "1111",
                    UserType = UserType.Consultant
                }
            };

            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                   PersonalId = "305561797",
                   FirstName = "Bar",
                   LastName = "Janach",
                   Address = "Yagel"
                },

                new Customer()
                {
                   PersonalId = "465262556",
                   FirstName = "Dana",
                   LastName = "Kogen",
                   Address = "Herzeliya"
                },

                new Customer()
                {
                   PersonalId = "102234657",
                   FirstName = "Mor",
                   LastName = "Cohen",
                   Address = "Pardesia"
                },
                new Customer()
                {
                    PersonalId = "459800324",
                   FirstName = "Shai",
                   LastName = "Cohen",
                   Address = "Pardesia"
                },
                new Customer()
                {
                   PersonalId = "787564738",
                   FirstName = "Sharon",
                   LastName = "Lavi",
                   Address = "Ariel"
                },
                new Customer()
                {
                    PersonalId = "347483837",
                    FirstName = "Moshe",
                    LastName = "Janach",
                    Address = "Yahud"
                },
                new Customer()
                {
                    PersonalId = "573373848",
                    FirstName = "Eti",
                    LastName = "Kedem",
                    Address = "TLV"
                },
                new Customer()
                {
                    PersonalId = "29485758",
                    FirstName = "Aviva",
                    LastName = "Zaig",
                    Address = "Zehela"
                },
                new Customer()
                {
                    PersonalId = "22099786",
                    FirstName = "Natan",
                    LastName = "Mizrahi",
                    Address = "Ashdod"
                },
                new Customer()
                {
                    PersonalId = "395967494",
                    FirstName = "David",
                    LastName = "Buzaglo",
                    Address = "Haifa"
                },
                new Customer()
                {
                    PersonalId = "3244677574",
                    FirstName = "Kim",
                    LastName = "Damari",
                    Address = "Zfat"
                },
                new Customer()
                {
                    PersonalId = "398878575",
                    FirstName = "Yossi",
                    LastName = "Nadir",
                    Address = "Yavne"
                },
                new Customer()
                {
                    PersonalId = "375847383",
                    FirstName = "Ben",
                    LastName = "Nahman",
                    Address = "Or-Yehuda"
                },
                new Customer()
                {
                    
                    PersonalId = "3348876758",
                    FirstName = "Karin",
                    LastName = "Shalom",
                    Address = "Ramat-Hasharon"
                }

            };

       
            await dbContext.Users.AddRangeAsync(users);
            await dbContext.Customers.AddRangeAsync(customers);
            await dbContext.SaveChangesAsync();
            var customerdb = await dbContext.Customers.ToDictionaryAsync(k => k.PersonalId);
            var usersdb = await dbContext.Users.ToDictionaryAsync(k => k.UserType);

            List <Meeting> meetings = new List<Meeting>()
            {
                new Meeting()
                {
                    Date = DateTime.Now.Date,
                    MeetingSubject = "New Joined",
                    Description = "Meetings at home",
                    CustomerId = customerdb["3348876758"].CustomerId,
                    UserId = usersdb[UserType.Admin].UserId
                    
                },
                new Meeting()
                {
                     Date = DateTime.Now.Date,
                     MeetingSubject = "Old Joined",
                     Description = "This customer gets service in his home",
                     CustomerId = customerdb["375847383"].CustomerId,
                     UserId = usersdb[UserType.Admin].UserId
                },
                new Meeting()
                {
                    Date = DateTime.Now.Date,
                    MeetingSubject = "New Customer",
                    Description = "Meetings at coffee shop",
                    CustomerId = customerdb["3244677574"].CustomerId,
                    UserId = usersdb[UserType.Admin].UserId
                },
                new Meeting()
                {
                    Date = DateTime.Now.Date,
                    MeetingSubject = "Old customer",
                    Description = "Wants a new meeting",
                    CustomerId = customerdb["22099786"].CustomerId,
                    UserId = usersdb[UserType.Consultant].UserId
                }

            };

            await dbContext.Meetings.AddRangeAsync(meetings);
            await dbContext.SaveChangesAsync();
        }

    }
}
