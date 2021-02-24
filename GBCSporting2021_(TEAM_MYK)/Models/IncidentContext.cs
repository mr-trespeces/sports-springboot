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
        }
    }
}
