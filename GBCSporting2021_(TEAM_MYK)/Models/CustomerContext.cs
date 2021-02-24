using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Name = "YP",
                    Email = "youngpyung.yoo@georgebrown.ca",
                    City = "Toronto"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "Kent",
                    Email = "kent.ped@gerogebrown.ca",
                    City = "Waterloo"
                },
                new Customer
                {
                    CustomerId = 3,
                    Name = "Mark",
                    Email = "mark.tres@georgebrown.ca",
                    City = "London"
                });
        }
    }
}
