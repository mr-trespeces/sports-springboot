﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Incident> Incidents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Code = "QWE123",
                    Name = "TV",
                    Price = "$999.99",
                    ReleaseDate = "12-12-2020"
                },
                new Product
                {
                    ProductId = 2,
                    Code = "ASD456",
                    Name = "Sofa",
                    Price = "$555.55",
                    ReleaseDate = "11-13-2012"
                },
                new Product
                {
                    ProductId = 3,
                    Code = "ZXC789",
                    Name = "Laptop",
                    Price = "$2.00",
                    ReleaseDate = "2-23-2018"
                });

            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    TechnicianId = 1,
                    Name = "Technician1",
                    Email = "tech1@georgebrown.ca",
                    Phone = "4168540113"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Name = "Technician2",
                    Email = "tech2@gerogebrown.ca",
                    Phone = "4167542904"
                },
                new Technician
                {
                    TechnicianId = 3,
                    Name = "Technician3",
                    Email = "tech3@georgebrown.ca",
                    Phone = "4167125209"
                });

            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    CustomerId = 1,
                    ProductId = 1,
                    Title = "Could not fix",
                    Description = "Hello :)",
                    TechnicianId = 1,
                    DateOpened = "9-2-2012",
                    DateClosed = "1-14-2013"
                },
                new Incident
                {
                    IncidentId = 2,
                    CustomerId = 2,
                    ProductId = 2,
                    Title = "Could not open",
                    Description = "Hi :(",
                    TechnicianId = 2,
                    DateOpened = "5-21-1992",
                    DateClosed = "8-19-2012"
                },
                new Incident
                {
                    IncidentId = 3,
                    CustomerId = 3,
                    ProductId = 3,
                    Title = "Could not turn on",
                    Description = "Yes ./.",
                    TechnicianId = 3,
                    DateOpened = "12-3-2017",
                    DateClosed = "3-18-2019"
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
                    CountryId = 5,
                    Email = "kent.pedro@georgebrown.ca",
                    Phone = "4161932185"
                });
        }
    }
}