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
        public string Id { get; set; }
        public Book Book { get; set; }

        //todo nath , i am not passing id in client , why do i get it in book ??
        public IActionResult OnPost(Book book)
        {
            int index = BooksUtils.GetBooks().FindIndex(book => book.Id == book.Id);
            if (index != -1)
            {
                BooksUtils.GetBooks()[index] = book;
                return RedirectToPage("/Books/Index");
            }

            return RedirectToPage("/NotFound");
        }

        public IActionResult OnGet(string id)
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