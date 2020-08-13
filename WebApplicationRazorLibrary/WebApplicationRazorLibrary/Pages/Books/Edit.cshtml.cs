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
        private IBooksRepository m_booksRepo;

        public EditModel(IBooksRepository booksRepo)
        {
            m_booksRepo = booksRepo;
        }

        // --- i do not want Id to be set outside of the class
        public long Id { get; private set; }

        // --- i do not want Book to be set outside of the class
        public Book Book { get; private set; }

        public IActionResult OnPost(Book book)
        {
            if (ModelState.IsValid)
            {
                if (m_booksRepo.GetBook(book.Id) != null)
                {
                    m_booksRepo.UpdateBook(book);
                    return RedirectToPage("/Books/Index");
                }

                return RedirectToPage("/NotFound");
            }

            //Book = book; looks like it is not needed
            return Page();
        }

        public IActionResult OnGet(long id)
        {
            Id = id;
            Book = m_booksRepo.GetBook(id);
            if (Book != null)
            {
                return Page();
            }

            return RedirectToPage("/NotFound");
        }
    }
}