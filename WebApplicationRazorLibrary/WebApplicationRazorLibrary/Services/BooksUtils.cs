using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Services
{
    public class BooksUtils
    {
        public static IEnumerable<BooksCountByCategory> GetBooksCount(IBooksRepository booksRepository)
        {
            return booksRepository.GetAll().GroupBy(book => book.Category).
                            Select(group => new BooksCountByCategory
                            {
                                Category = group.Key,
                                Count = group.Count()
                            });
        }
    }
}
