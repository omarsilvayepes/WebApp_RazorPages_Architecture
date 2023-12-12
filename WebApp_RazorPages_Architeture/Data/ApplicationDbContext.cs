using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebApp_RazorPages_Architeture.Models;

namespace WebApp_RazorPages_Architeture.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }


        // set some data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Service", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Tecnology", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Transport", DisplayOrder = 3 }
                );
        }


    }
}
