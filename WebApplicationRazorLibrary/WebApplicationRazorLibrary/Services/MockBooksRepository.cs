using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Logic;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Services
{
    public class MockBooksRepository : IBooksRepository
    {
        List<Book> m_books = new List<Book>{
                new Book { Id = 1, Name = "Book1" , Author = "Author1" , Pages=111 , Category=Category.Classics} ,
                new Book { Id = 2, Name = "Book2" , Author = "Author2" , Pages=222 , Category=Category.Detective},
                new Book { Id = 3, Name = "Book3" , Author = "Author3" , Pages=333 , Category=Category.Horror}
            };

        // --- return IEnumerable is nice but later you need to supply API so return List
        // --- todo nath : can i make it return IEnumerable ??
        public List<Book> GetBooks()
        {
            return m_books;
        }

        private long getUniqueId()
        {
            return m_books.Max(it => it.Id) + 1;
        }

        // --- id is ignored , its self computed . using db you get id from there
        public void Add(Book book)
        {
            book.Id = getUniqueId();
            m_books.Add(book);
        }
    }
}
