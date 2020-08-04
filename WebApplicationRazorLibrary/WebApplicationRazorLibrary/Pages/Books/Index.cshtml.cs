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
    public class IndexModel : PageModel
    {
        public Book[] Books { get; } = BooksUtils.GetBooks();
        public void OnGet()
        {

        }
    }
}