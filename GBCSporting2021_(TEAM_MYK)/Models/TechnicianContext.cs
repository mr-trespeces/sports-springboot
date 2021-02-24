using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class TechnicianContext : DbContext
    {
        public TechnicianContext(DbContextOptions<TechnicianContext> options) : base(options)
        {

        }

        public DbSet<Technician> Technicians { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}
