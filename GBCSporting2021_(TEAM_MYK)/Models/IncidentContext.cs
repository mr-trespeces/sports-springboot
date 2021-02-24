using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class IncidentContext : DbContext
    {
        public IncidentContext(DbContextOptions<IncidentContext> options) : base(options)
        {

        }

        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    Title = "Hello",
                    Customer = "YP",
                    Product = "This",
                    DateOpened = "10-15-2002"
                },
                new Incident
                {
                    IncidentId = 2,
                    Title = "Hi",
                    Customer = "Mark",
                    Product = "That",
                    DateOpened = "2-18-2010"
                },
                new Incident
                {
                    IncidentId = 3,
                    Title = "Yes",
                    Customer = "Kent",
                    Product = "Those",
                    DateOpened = "12-15-2011"
                });
        }
    }
}
