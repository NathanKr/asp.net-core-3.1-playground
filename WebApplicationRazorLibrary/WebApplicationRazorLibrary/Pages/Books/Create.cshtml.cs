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
    public class CreateModel : PageModel
    {
        public Book Book { get; set; }

        public IActionResult OnPost(Book book)
        {
            if (ModelState.IsValid)
            {
                BooksUtils.Add(book);
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