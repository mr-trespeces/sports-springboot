using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class SportingContext : DbContext
    {
        public SportingContext(DbContextOptions<SportingContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Code = "QWE123",
                    Name = "Bat",
                    Price = "10.99",
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 2,
                    Code = "ASD456",
                    Name = "Net",
                    Price = "15.55",
                    ReleaseDate = DateTime.Now,
                },
                new Product
                {
                    ProductId = 3,
                    Code = "ZXC789",
                    Name = "Ball",
                    Price = "$2.00",
                    ReleaseDate = DateTime.Now
                });

            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    TechnicianId = 1,
                    Name = "Gowther Kangman",
                    Email = "gowther@georgebrown.ca",
                    Phone = "416-854-0113"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Name = "Tiny Tony",
                    Email = "tiny.tony@gmail.com",
                    Phone = "4167542904"
                },
                new Technician
                {
                    TechnicianId = 3,
                    Name = "Duc Mihn",
                    Email = "duc.mihn@yahoo.com",
                    Phone = "4167125209"
                });

            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    CustomerId = 1,
                    ProductId = 3,
                    Title = "Explosion",
                    Description = "The ball exploded.",
                    TechnicianId = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now
                },
                new Incident
                {
                    IncidentId = 2,
                    CustomerId = 2,
                    ProductId = 1,
                    Title = "Broken Leg",
                    Description = "Broken leg because of the bat.",
                    TechnicianId = 2,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now
                },
                new Incident
                {
                    IncidentId = 3,
                    CustomerId = 3,
                    ProductId = 3,
                    Title = "Ripped Net",
                    Description = "The net ripped.",
                    TechnicianId = 3,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now
                });


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
                    CountryId = 3,
                    Email = "kent.pedro@georgebrown.ca",
                    Phone = "4161932185"
                });

            modelBuilder.Entity<Registration>().HasData(
               new Registration     
               {
                   RegistrationId = 1,
                   CustomerId = 1,
                   ProductId = 1,
               },
                new Registration
                {
                    RegistrationId = 2,
                    CustomerId = 1,
                    ProductId = 2,
                },
                new Registration
                {
                    RegistrationId = 3,
                    CustomerId = 2,
                    ProductId = 1,

                },
                new Registration
                {
                    RegistrationId = 4,
                    CustomerId = 3,
                    ProductId = 2,

                });
        }
    }
}
