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
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "Kyrgyzstan" },
                new Country { CountryId = 2, Name = "Brunei" },
                new Country { CountryId = 3, Name = "Kiribati" },
                new Country { CountryId = 4, Name = "Vanuatu" },
                new Country { CountryId = 5, Name = "Tajikistan" }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Firstname = "YP",
                    Lastname = "Yoo",
                    Address = "1396 Harvest Moon Dr",
                    City = "Balykchy",
                    State = "Bishkek",
                    Postalcode = "L3R 0L7",
                    CountryId = 1,
                    Email = "yp.yoo@georgebrown.ca",
                    Phone = "4167240128"
                },
                new Customer
                {
                    CustomerId = 2,
                    Firstname = "Mark",
                    Lastname = "Tres",
                    Address = "1863 Lynden Road",
                    City = "Tutong",
                    State = "Belait",
                    Postalcode = "L0B 1B0",
                    CountryId = 2,
                    Email = "mark.tres@georgebrown.ca",
                    Phone = "4161720326"
                },
                new Customer
                {
                    CustomerId = 3,
                    Firstname = "Kent",
                    Lastname = "Pedro",
                    Address = "4354 Wallace Street",
                    City = "Panjakent",
                    State = "Norak",
                    Postalcode = "V9R 3A8",
                    CountryId = 5,
                    Email = "kent.pedro@georgebrown.ca",
                    Phone = "4161932185"
                });
        }
    }
}
