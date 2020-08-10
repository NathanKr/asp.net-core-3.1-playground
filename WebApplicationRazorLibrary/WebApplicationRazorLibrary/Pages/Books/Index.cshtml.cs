using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazorLibrary.Logic;
using WebApplicationRazorLibrary.Models;
using WebApplicationRazorLibrary.Services;

namespace WebApplicationRazorLibrary.Pages.Books
{
    public class IndexModel : PageModel
    {
        private IBooksRepository m_iBooksStorage;

        public IndexModel(IBooksRepository iBooksStorage)
        {
            m_iBooksStorage = iBooksStorage;
        }

        public IEnumerable<Book> Books { get { return m_iBooksStorage.GetAll(); } }
        public void OnGet()
        {

        }
    }
}