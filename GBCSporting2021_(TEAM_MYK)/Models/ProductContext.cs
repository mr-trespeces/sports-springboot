using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Code = "QWE123",
                    Name = "YP",
                    Price = "$999.99",
                    ReleaseDate = "10/23/1996"
                },
                new Product
                {
                    ProductId = 2,
                    Code = "ASD456",
                    Name = "Mark",
                    Price = "$555.55",
                    ReleaseDate = "2/11/1997"
                },
                new Product
                {
                    ProductId = 3,
                    Code = "ZXC789",
                    Name = "Kent",
                    Price = "$2.00",
                    ReleaseDate = "6/2/1963"
                });
        }
    }
}
