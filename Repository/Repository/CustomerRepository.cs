using DAL.DataAccess;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// This class holds properties of Meetings table and Customers table to join them
    /// </summary>
    public class MeetingAndCustomersDTO
    {              
        public int CustomerId { get; set; }
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int MeetingId { get; set; }
        public DateTime Date { get; set; }
        public string MeetingSubject { get; set; }
        public string Description { get; set; }

    }
    /// <summary>
    /// This class allows to add a customer or get all customers
    /// </summary>
    public class CustomerRepository
    {
        ConsultantsManagementDbContext dbContext = new ConsultantsManagementDbContext();

        public async Task<Message> AddNewCustomerAsync(string personalId, string firstName, string lastName, string address)
        {
          
            try
            {
                if (string.IsNullOrEmpty(personalId))
                {
                    return new Message { IsSuccess = false, Content = "Personal ID is required" };
                }
                if (string.IsNullOrEmpty(firstName))
                    return new Message { IsSuccess = false, Content = "First name is required" };
                if (string.IsNullOrEmpty(lastName))
                    return new Message { IsSuccess = false, Content = "Last name is required" };

                using (var conn = new ConsultantsManagementDbContext())
                {
                    var personalIdExist = await conn.Customers.Where(x => x.PersonalId == personalId).FirstOrDefaultAsync();
                    if(personalIdExist != null)
                    {
                        return new Message { IsSuccess = false, Content = "Personal ID already exist" };
                    }
                    await conn.Customers.AddAsync(new Model.Customer
                    {
                        PersonalId = personalId,
                        FirstName = firstName,
                        LastName = lastName,
                        Address = address
                    });
                    await conn.SaveChangesAsync();

                    return new Message { IsSuccess = true, Content = "Customer is added succefully" };
                }
            }
            catch
            {
                return new Message { IsSuccess = false, Content = "Customer can't be added" };

            }
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            try
            {
                return await dbContext.Customers.ToListAsync();
            }
            catch
            {
                return new List<Customer>();
            }
        }

        
        public async Task<IEnumerable<MeetingAndCustomersDTO>> GetCustomersAppointmentsAsync()
        {
            try
            {
                return await dbContext.Meetings
                                .Include(x => x.Customer)
                                .Select(row => new
                                MeetingAndCustomersDTO
                                {
                                    CustomerId = row.Customer.CustomerId,
                                    PersonalId = row.Customer.PersonalId,
                                    FirstName = row.Customer.FirstName,
                                    LastName = row.Customer.LastName,
                                    Address = row.Customer.Address,
                                    MeetingId = row.MeetingId,
                                    Date = row.Date,
                                    MeetingSubject = row.MeetingSubject,
                                    Description = row.Description
                                }).ToListAsync();

            }
            catch
            {
                return new List<MeetingAndCustomersDTO>();
            }
        }
    }
}
