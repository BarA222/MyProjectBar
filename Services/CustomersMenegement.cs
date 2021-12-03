using Contracts;
using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Customer service business logic class, implements the ICustomer
    /// </summary>
    public class CustomersMenegement : ICustomer
    {
        private CustomerRepository repo = new CustomerRepository();

        public async Task<Message> AddNewCustomer(string personalId, string firstName, string lastName, string address)
        {
           return await repo.AddNewCustomerAsync(personalId, firstName, lastName, address);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await repo.GetCustomersAsync();
        }

        public async Task<IEnumerable<MeetingAndCustomersDTO>> GetCustomersAppointments()
        {
            return await repo.GetCustomersAppointmentsAsync();
        }
    }
}
