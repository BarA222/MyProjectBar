using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    /// Interface for customers, add and get customers
    /// </summary>
    public interface ICustomer
    {
        Task<Message> AddNewCustomer(string personalId, string firstName, string lastName, string address);
        Task<List<Customer>> GetCustomers();
        Task<IEnumerable<MeetingAndCustomersDTO>> GetCustomersAppointments();
    }
}
