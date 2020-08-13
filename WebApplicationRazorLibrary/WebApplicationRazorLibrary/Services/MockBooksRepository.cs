using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Logic;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Services
{
    // --- MockBooksRepository does not obey  IBooksRepository in the sense that you can change the repository via the return object
    // --- but this is only mock so i did not put effor on this . it is not possible in SqlBooksRepository
    public class MockBooksRepository : IBooksRepository
    {
        List<Book> m_books = new List<Book>{
                new Book { Id = 1, Name = "Book1" , Author = "Author1" , Pages=111 , Category=BooksCategory.Classics} ,
                new Book { Id = 2, Name = "Book2" , Author = "Author2" , Pages=222 , Category=BooksCategory.Detective},
                new Book { Id = 3, Name = "Book3" , Author = "Author3" , Pages=333 , Category=BooksCategory.Horror}
            };

        public IEnumerable<Book> GetAll()
        {
            return m_books;
        }

        private long getUniqueId()
        {
            return m_books.Max(it => it.Id) + 1;
        }

        // --- id is ignored , its self computed . using db you get id from there
        public Book AddBook(Book book)
        {
            book.Id = getUniqueId();
            m_books.Add(book);// --- add in the end
            return m_books.Last();
        }

        public Book GetBook(long id)
        {
            // --- i provide reference to the repository but its non issue because its mock , in gebneral access to repo is only by API
            return m_books.FirstOrDefault(book => book.Id == id);
        }

        

        public Book UpdateBook(Book updatedBook)
        {
            // --- i provide reference to the repository but its non issue because its mock , in gebneral access to repo is only by API
            int index = m_books.FindIndex(book => updatedBook.Id == book.Id);
            if (index != -1)
            {
                m_books[index] = updatedBook;
                return m_books[index];
            }

            return null;
        }

        public Book DeleteBook(long id)
        {
            Book book = GetBook(id);
            if (book != null)
            {
                m_books.Remove(book);
            }

            return book;
        }
    }
}
