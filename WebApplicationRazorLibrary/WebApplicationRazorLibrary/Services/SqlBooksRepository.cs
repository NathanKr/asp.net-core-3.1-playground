using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Logic;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Services
{
    public class SqlBooksRepository : IBooksRepository
    {
        private AppDbContext m_dbContext;

        public SqlBooksRepository(AppDbContext dbContext)
        {
            m_dbContext = dbContext;
            // ---- do not allow changing the repository via object returned from the repository
            m_dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        

        public Book Add(Book book)
        {
            m_dbContext.Books.Add(book);
            m_dbContext.SaveChanges();
            return book;//todo nath is id changed ????
        }

        public Book Delete(long id)
        {
            Book book = m_dbContext.Books.Find(id);
            if(book != null)
            {
                m_dbContext.Books.Remove(book);
                m_dbContext.SaveChanges();
            }
            return book;
        }

        public Book Get(long id)
        {
            return m_dbContext.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return m_dbContext.Books;
        }

        public Book Update(Book updateBook)
        {
            if (m_dbContext.Books.Find(updateBook.Id) != null)
            {
                // --- attch is better than Update because it updated only what was changed
                // --- i am geeting here exception : "The instance of entity type 'Book' cannot be tracked because another instance with the key value '{Id: 5}' is already being tracked"
                var book = m_dbContext.Books.Attach(updateBook);
                book.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                m_dbContext.SaveChanges();
                return updateBook;
            }

            return null;
        }
    }
}
