using Labb1.Models.Interfaces;
using Labb1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Labb1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;



        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }



        public ViewResult Index()
        {
            return View(_customerRepository.GetAllCustomers.ToList());

        }

        // GET: Customer/Customer/2
        public IActionResult Customer(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CustomerId, FirstName, LastName, Email")] Customer customer)
        {

            _customerRepository.CreateCustomer(customer);
            return RedirectToAction(nameof(Index));


        }


        public IActionResult Delete(int id)
        {
            Customer customer = _customerRepository.GetCustomerById(id);
            _customerRepository.deleteCustomer(customer.CustomerId);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            return View(_customerRepository.GetCustomerById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            _customerRepository.updateCustomer(customer);
            return View();

        }
    }
}
