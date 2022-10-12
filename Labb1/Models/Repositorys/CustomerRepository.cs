using Labb1.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Labb1.Models.Repositorys
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;
        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void CreateCustomer(Customer customer)
        {

            _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _appDbContext.Customers;
            }
        }


        public Customer GetCustomerById(int id)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public void updateCustomer(Customer customer)
        {
            _appDbContext.Update(customer);
            _appDbContext.SaveChanges();
        }

        public void deleteCustomer(int id)
        {
            Customer customer = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            _appDbContext.Customers.Remove(customer);
            _appDbContext.SaveChanges();
        }
    }
}
