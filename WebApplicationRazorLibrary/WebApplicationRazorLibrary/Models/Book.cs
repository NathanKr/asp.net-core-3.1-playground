using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazorLibrary.Logic;

namespace WebApplicationRazorLibrary.Models
{
    public class Book
    {
        public long Id{ get; set; }

        [Required]
        public string Name { get; set; }

        [Required] 
        public string Author { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public uint Pages { get; set; }

        [Required]
        public BooksCategory Category { get; set; }

    }
}
