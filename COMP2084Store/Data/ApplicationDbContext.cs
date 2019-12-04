using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP2084Store.Models;

namespace COMP2084Store.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<COMP2084Store.Models.Brands> Brands { get; set; }
        public DbSet<COMP2084Store.Models.ShoeType> ShoeType { get; set; }
        public DbSet<COMP2084Store.Models.Shoes> Shoes { get; set; }
    }
}
