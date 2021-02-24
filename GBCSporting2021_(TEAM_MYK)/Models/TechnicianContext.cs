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
                    Name = "YP",
                    Email = "youngpyung.yoo@georgebrown.ca",
                    Phone = "4168540113"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Name = "Kent",
                    Email = "kent.ped@gerogebrown.ca",
                    Phone = "4167542904"
                },
                new Technician
                {
                    TechnicianId = 3,
                    Name = "Mark",
                    Email = "mark.tres@georgebrown.ca",
                    Phone = "4167125209"
                });
        }
    }
}
