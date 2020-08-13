using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;
using WebApplicationRazorLibrary.Logic;
using WebApplicationRazorLibrary.Models;
using WebApplicationRazorLibrary.Services;

namespace WebApplicationRazorLibrary.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private IBooksRepository m_booksRepo;

        public DetailsModel(IBooksRepository booksRepo)
        {
            m_booksRepo = booksRepo;
        }


        // --- i do not want Details to be set outside of the class
        public Book Book { get; private set; }

        /*  
         * razor page MUST be decalred with @page "{id}"
         * id is same as Request.RouteValues["id"]
         * we have changed OnGet return code to IActionResult to handle return
         */
        public IActionResult OnGet(long id)
        {
            Book = m_booksRepo.GetBook(id);
            if(Book == null)
            {
               return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}