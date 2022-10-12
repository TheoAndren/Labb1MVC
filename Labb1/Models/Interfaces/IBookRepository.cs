using System.Collections.Generic;

namespace Labb1.Models.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
    }
}
