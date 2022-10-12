using Labb1.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Labb1.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepo;


        public BookController(IBookRepository bookRepository)
        {
            _bookRepo = bookRepository;
        }
        public IActionResult Index()
        {
            return View(_bookRepo.GetAllBooks.ToList());
        }
    }
}
