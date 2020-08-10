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
    public class EditModel : PageModel
    {
        private IBooksRepository m_iBooksStorage;

        public EditModel(IBooksRepository iBooksStorage)
        {
            m_iBooksStorage = iBooksStorage;
        }

        // --- i do not want Id to be set outside of the class
        public long Id { get; private set; }

        // --- i do not want Book to be set outside of the class
        public Book Book { get; private set; }

        public IActionResult OnPost(Book book)
        {
            if (ModelState.IsValid)
            {
                int index = m_iBooksStorage.GetBooks().FindIndex(book => book.Id == book.Id);
                if (index != -1)
                {
                    m_iBooksStorage.GetBooks()[index] = book;
                    return RedirectToPage("/Books/Index");
                }

                return RedirectToPage("/NotFound");
            }

            Book = book;
            return Page();
        }

        public IActionResult OnGet(long id)
        {
            Id = id;
            int index = m_iBooksStorage.GetBooks().FindIndex(book => book.Id == id);
            if (index != -1)
            {
                Book = m_iBooksStorage.GetBooks()[index];
                return Page();
            }

            return RedirectToPage("/NotFound");
        }
    }
}