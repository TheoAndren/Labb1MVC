using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb1.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Avalible { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<CustomerBook> CustomerBooks { get; set; }
    }
}
