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
        Book Get(long id);
        // --- input id is ignored , it is computed in Add
        Book Add(Book book);
        Book Update(Book book);
        Book Delete(long id);

    }
}
