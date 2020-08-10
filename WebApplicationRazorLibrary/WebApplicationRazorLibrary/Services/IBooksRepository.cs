using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Services
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAll();
        Book Get(long id);
        Book Add(Book book);
        Book Update(Book book);
        Book Delete(long id);

    }
}
