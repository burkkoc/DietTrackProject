using EFDiyet2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFDiyet2.DAL.Context
{
    public class EFDiyet2DbContext:DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFood> UsersFood { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9UHMGPO\\MSSQLSERVER01;Database=EfDıet2ProSonHalj;Trusted_Connection=True;TrustServerCertificate=true");
            optionsBuilder.UseLazyLoadingProxies();
            

            base.OnConfiguring(optionsBuilder);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            base.OnModelCreating(modelBuilder);
        }

 
    }
}
