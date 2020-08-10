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
        private IBooksRepository m_iBooksStorage;

        public DeleteModel(IBooksRepository iBooksStorage)
        {
            m_iBooksStorage = iBooksStorage;
        }

        /*  
         * razor page MUST be decalred with @page "{id}"
         * id is same as Request.RouteValues["id"]
         * we have changed OnGet return code to IActionResult to handle return
         */
        public IActionResult OnGet(long id)
        {
            int index = m_iBooksStorage.GetBooks().FindIndex(book => book.Id == id);
            if(index != -1)
            {
                m_iBooksStorage.GetBooks().RemoveAt(index);
                return RedirectToPage("/Books/Index");
            }
            
            
            return RedirectToPage("/NotFound");
        }
    }
}