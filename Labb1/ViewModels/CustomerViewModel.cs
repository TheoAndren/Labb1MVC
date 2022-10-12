using Labb1.Models;
using System.Collections.Generic;

namespace Labb1.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerBook CustomerBook { get; set; }
        public IEnumerable<Customer> customers { get; set; }
    }
}