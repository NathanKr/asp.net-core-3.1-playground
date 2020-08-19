using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationASP.NetCoreMVCwithIdentity.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)] // request only date
        public DateTime ReleaseDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Genre { get; set; }// --- todo change later to enum
    }
}
