using Labb1.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Labb1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CustomerBook> CustomerBooks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Customers
            modelBuilder.Entity<Customer>().HasData(new Customer { FirstName = "Theo", LastName = "Andrén", Email = "theokingen@gmail.com", CustomerId = 1 });
            modelBuilder.Entity<Customer>().HasData(new Customer { FirstName = "Anas", LastName = "Qlok", Email = "Anasekung123@gmail.com", CustomerId = 2 });
            
            
            //Books
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Harry Potter och De Vises Sten", 
                Author = "J.K. Rowling", Avalible = false, BookId = 1, ImageUrl = "https://kbimages1-a.akamaihd.net/90aadf1a-79ea-4942-b055-2391cba20012/353/569/90/False/harry-potter-og-de-vises-sten.jpg"
            });
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Harry Potter och Hemligheternas kammare", 
                Author = "J.K. Rowling", Avalible = false, BookId = 2, ImageUrl = "https://kbimages1-a.akamaihd.net/63661c91-7cb6-4ec0-bd67-9dd1810d00b2/353/569/90/False/harry-potter-och-hemligheternas-kammare.jpg"
            });
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Harry Potter and the Prisoner of Azkaban", 
                Author = "J.K. Rowling", Avalible = false, BookId = 3, ImageUrl = "https://kbimages1-a.akamaihd.net/f5e2b97b-0438-4cd5-8a47-09c26b3fb4cf/353/569/90/False/harry-potter-and-the-prisoner-of-azkaban-5.jpg"
            });
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Harry Potter och den flammande bägaren", 
                Author = "J.K. Rowling", Avalible = false, BookId = 4, ImageUrl = "https://kbimages1-a.akamaihd.net/da827f3c-534e-4cdc-b1ae-103d8a8bf4c8/353/569/90/False/harry-potter-och-den-flammande-bagaren.jpg"
            });

            //CustomerBooks

            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook { CustomerId = 2, BookId = 2, CustomerBookId = 3, 
                LoanDate = new DateTime(2021, 09, 23), ReturnDate = new DateTime(2022, 10, 14) });
            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook { CustomerId = 1, BookId = 2, CustomerBookId = 2, 
                LoanDate = DateTime.Now, ReturnDate = new DateTime(2022, 10, 20) });
            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook { CustomerId = 1, BookId = 1, CustomerBookId = 1, 
                LoanDate = new DateTime(2022, 08, 23), ReturnDate = new DateTime(2022, 10, 17) });

        }
    }
}
