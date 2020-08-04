using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Logic
{
    public class BooksUtils
    {
        public static Book[] GetBooks()
        {
            Book[] books  = {
                new Book { Id = "1", Name = "Book1" } ,
                new Book { Id = "2", Name = "Book2" },
                new Book { Id = "3", Name = "Book3" }
            };

            return books;
        }
    }
}
