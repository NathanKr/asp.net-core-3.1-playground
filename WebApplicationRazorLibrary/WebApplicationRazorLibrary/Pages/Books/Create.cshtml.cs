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
        IBooksRepository m_booksRepo;

        // --- i do not want Book to be set outside of the class
        public Book Book { get; private set; }

        public CreateModel(IBooksRepository booksRepo)
        {
            m_booksRepo = booksRepo;
        }

        public IActionResult OnPost(Book book)
        {
            if (ModelState.IsValid)
            {
                m_booksRepo.AddBook(book);
                return RedirectToPage("/Books/Index");
            }

            //Book = book; looks like it is not needed
            return Page();
        }

        public void OnGet()
        {
        }
    }
}