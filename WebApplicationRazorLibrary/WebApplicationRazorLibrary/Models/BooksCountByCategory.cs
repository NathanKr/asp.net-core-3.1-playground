using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Logic;

namespace WebApplicationRazorLibrary.Models
{
    public class BooksCountByCategory
    {
        public BooksCategory Category { get; set; }
        public int Count { get; set; }
    }
}
