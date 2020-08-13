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
    public class DeleteModel : PageModel
    {
        private IBooksRepository m_booksRepo;

        //[BindProperty] todo nath , should i use it
        public Book Book { get; private set; }
        public DeleteModel(IBooksRepository booksRepo)
        {
            m_booksRepo = booksRepo;
        }

        // --- todo nath , where does he get id
        public IActionResult OnPost(long id)
        {
           // long id = Book.Id;
            if (m_booksRepo.GetBook(id) == null)
            {
                return RedirectToPage("/NotFound");
            }

            m_booksRepo.DeleteBook(id);
            return RedirectToPage("/Books/Index");
        }
            /*  
             * razor page MUST be decalred with @page "{id}"
             * id is same as Request.RouteValues["id"]
             * we have changed OnGet return code to IActionResult to handle return
             */
            public IActionResult OnGet(long id)
        {
            Book = m_booksRepo.GetBook(id);
            if (Book == null)
            {
                return RedirectToPage("/NotFound");
            }


            return Page();
        }
    }
}