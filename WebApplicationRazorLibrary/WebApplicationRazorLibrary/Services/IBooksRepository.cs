using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Services
{
    public interface IBooksRepository
    {
        List<Book> GetBooks();
        void Add(Book book);
    }
}
