using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb1.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter your first name")]
        [MaxLength(50)]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        [MaxLength(50)]
        [MinLength(2)]
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<CustomerBook> CustomerBooks { get; set; }
    }
}
