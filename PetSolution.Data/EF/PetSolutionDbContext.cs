using Microsoft.EntityFrameworkCore;
using PetSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetSolution.Data.EF
{
    public class PetSolutionDbContext: DbContext
    {
        public PetSolutionDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }



    }
}
