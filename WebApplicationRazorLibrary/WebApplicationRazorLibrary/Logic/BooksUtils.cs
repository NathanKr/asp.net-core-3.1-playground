using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Logic
{
    public class BooksUtils
    {
        static List<Book> m_books = new List<Book>{
                new Book { Id = "1", Name = "Book1" , Author = "Author1" , Pages=111} ,
                new Book { Id = "2", Name = "Book2" , Author = "Author2" , Pages=222},
                new Book { Id = "3", Name = "Book3" , Author = "Author3" , Pages=333}
            };
        public static List<Book> GetBooks()
        {
            return m_books;
        }
    }
}
