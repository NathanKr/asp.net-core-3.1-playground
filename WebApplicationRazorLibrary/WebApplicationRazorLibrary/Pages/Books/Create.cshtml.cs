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
    public class CreateModel : PageModel
    {
        IBooksRepository m_iBooksStorage;

        // --- i do not want Book to be set outside of the class
        public Book Book { get; private set; }

        public CreateModel(IBooksRepository iBooksStorage)
        {
            m_iBooksStorage = iBooksStorage;
        }

        public IActionResult OnPost(Book book)
        {
            if (ModelState.IsValid)
            {
                m_iBooksStorage.Add(book);
                return RedirectToPage("/Books/Index");
            }

            Book = book;
            return Page();
        }

        public void OnGet()
        {
        }
    }
}