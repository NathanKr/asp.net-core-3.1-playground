using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationRazorLibrary.Models;
using WebApplicationRazorLibrary.Services;

namespace WebApplicationRazorLibrary.ViewComponents
{
    public class BooksCountByCategoryViewComponent : ViewComponent
    {
        private IBooksRepository m_booksRepo;

        public BooksCountByCategoryViewComponent(IBooksRepository booksRepo)
        {
            m_booksRepo = booksRepo;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<BooksCountByCategory> bookCountList =
                BooksUtils.GetBooksCount(m_booksRepo);

            return View(bookCountList);
        }
    }
}
