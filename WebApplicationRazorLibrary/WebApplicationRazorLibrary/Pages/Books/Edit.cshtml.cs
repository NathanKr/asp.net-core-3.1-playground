using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazorLibrary.Logic;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Pages.Books
{
    public class EditModel : PageModel
    {
        public long Id { get; set; }
        public Book Book { get; set; }

        public IActionResult OnPost(Book book)
        {
            if (ModelState.IsValid)
            {
                int index = BooksUtils.GetBooks().FindIndex(book => book.Id == book.Id);
                if (index != -1)
                {
                    BooksUtils.GetBooks()[index] = book;
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
            int index = BooksUtils.GetBooks().FindIndex(book => book.Id == id);
            if (index != -1)
            {
                Book = BooksUtils.GetBooks()[index];
                return Page();
            }

            return RedirectToPage("/NotFound");
        }
    }
}