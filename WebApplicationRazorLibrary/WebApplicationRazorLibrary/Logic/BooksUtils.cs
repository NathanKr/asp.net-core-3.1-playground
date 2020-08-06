using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Logic
{
    public class BooksUtils
    {
        static List<Book> m_books = new List<Book>{
                new Book { Id = "1", Name = "Book1" , Author = "Author1" , Pages=111 , Category=Category.Classics} ,
                new Book { Id = "2", Name = "Book2" , Author = "Author2" , Pages=222 , Category=Category.Detective},
                new Book { Id = "3", Name = "Book3" , Author = "Author3" , Pages=333 , Category=Category.Horror}
            };
        public static List<Book> GetBooks()
        {
            return m_books;   
        }

        private static string getUniqueId()
        {
            int maxId = int.Parse(m_books.Max(it => it.Id))+1;
            return maxId.ToString();
        }

        // --- id is ignired , its self computed . using db you get id from there
        public static void Add(Book book)
        {
            book.Id = getUniqueId();
            m_books.Add(book);
        }
    }
}
