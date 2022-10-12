using System.Collections.Generic;

namespace Labb1.Models.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers { get; }
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
        void updateCustomer(Customer customer);
        void deleteCustomer(int id);
    }
}
