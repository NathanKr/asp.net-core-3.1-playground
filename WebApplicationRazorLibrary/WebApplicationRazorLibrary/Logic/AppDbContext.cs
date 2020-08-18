using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazorLibrary.Models;

namespace WebApplicationRazorLibrary.Logic
{
    //public class AppDbContext : DbContext
    //ultimately IdentityDbContext inherit DbContext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // --- represent books table
        public DbSet<Book> Books{ get; set; }
    }
}
