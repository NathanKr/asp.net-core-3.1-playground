using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Services
{
    // -- changes done on return object should not effect the repository
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAll();
        Book GetBook(long id);
        // --- input id is ignored , it is computed in Add
        Book AddBook(Book book);
        Book UpdateBook(Book book);
        Book DeleteBook(long id);
    }
}
