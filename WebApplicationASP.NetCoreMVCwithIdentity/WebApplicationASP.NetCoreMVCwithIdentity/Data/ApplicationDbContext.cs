using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationASP.NetCoreMVCwithIdentity.Models;

namespace WebApplicationASP.NetCoreMVCwithIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplicationASP.NetCoreMVCwithIdentity.Models.Book> Book { get; set; }
    }
}
