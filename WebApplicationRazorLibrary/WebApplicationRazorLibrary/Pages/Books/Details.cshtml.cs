using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;
using WebApplicationRazorLibrary.Logic;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Pages.Books
{
    public class DetailsModel : PageModel
    {
        public Book Details { get; set; }

        /*  
         * razor page MUST be decalred with @page "{id}"
         * id is same as Request.RouteValues["id"]
         * we have changed OnGet return code to IActionResult to handle return
         */
        public IActionResult OnGet(long id)
        {
            Details = BooksUtils.GetBooks().FirstOrDefault(book => book.Id == id);
            if(Details == null)
            {
               return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}