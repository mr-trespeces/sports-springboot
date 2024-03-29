﻿// <auto-generated />
using System;
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GBCSporting2021__TEAM_MYK_.Migrations
{
    [DbContext(typeof(SportingContext))]
    partial class SportingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Kyrgyzstan"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Brunei"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Kiribati"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "Vanuatu"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Tajikistan"
                        });
                });

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(51)
                        .HasColumnType("nvarchar(51)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(51)
                        .HasColumnType("nvarchar(51)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(51)
                        .HasColumnType("nvarchar(51)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(51)
                        .HasColumnType("nvarchar(51)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(51)
                        .HasColumnType("nvarchar(51)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postalcode")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(51)
                        .HasColumnType("nvarchar(51)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "1396 Harvest Moon Dr",
                            City = "Balykchy",
                            CountryId = 1,
                            Email = "yp.yoo@georgebrown.ca",
                            Firstname = "YP",
                            Lastname = "Yoo",
                            Phone = "4167240128",
                            Postalcode = "L3R 0L7",
                            State = "Bishkek"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "1863 Lynden Road",
                            City = "Tutong",
                            CountryId = 2,
                            Email = "mark.tres@georgebrown.ca",
                            Firstname = "Mark",
                            Lastname = "Tres",
                            Phone = "4161720326",
                            Postalcode = "L0B 1B0",
                            State = "Belait"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "4354 Wallace Street",
                            City = "Panjakent",
                            CountryId = 3,
                            Email = "kent.pedro@georgebrown.ca",
                            Firstname = "Kent",
                            Lastname = "Pedro",
                            Phone = "4161932185",
                            Postalcode = "V9R 3A8",
                            State = "Norak"
                        });
                });

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Incident", b =>
                {
                    b.Property<int>("IncidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("TechnicianId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            IncidentId = 1,
                            CustomerId = 1,
                            DateClosed = new DateTime(2021, 4, 9, 20, 50, 21, 753, DateTimeKind.Local).AddTicks(8799),
                            DateOpened = new DateTime(2021, 4, 9, 20, 50, 21, 753, DateTimeKind.Local).AddTicks(8464),
                            Description = "The ball exploded.",
                            ProductId = 3,
                            TechnicianId = 1,
                            Title = "Explosion"
                        },
                        new
                        {
                            IncidentId = 2,
                            CustomerId = 2,
                            DateClosed = new DateTime(2021, 4, 9, 20, 50, 21, 753, DateTimeKind.Local).AddTicks(9138),
                            DateOpened = new DateTime(2021, 4, 9, 20, 50, 21, 753, DateTimeKind.Local).AddTicks(9126),
                            Description = "Broken leg because of the bat.",
                            ProductId = 1,
                            TechnicianId = 2,
                            Title = "Broken Leg"
                        },
                        new
                        {
                            IncidentId = 3,
                            CustomerId = 3,
                            DateClosed = new DateTime(2021, 4, 9, 20, 50, 21, 753, DateTimeKind.Local).AddTicks(9150),
                            DateOpened = new DateTime(2021, 4, 9, 20, 50, 21, 753, DateTimeKind.Local).AddTicks(9147),
                            Description = "The net ripped.",
                            ProductId = 3,
                            TechnicianId = 3,
                            Title = "Ripped Net"
                        });
                });

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Code = "QWE123",
                            Name = "Bat",
                            Price = "10.99",
                            ReleaseDate = new DateTime(2021, 4, 9, 20, 50, 21, 749, DateTimeKind.Local).AddTicks(3862)
                        },
                        new
                        {
                            ProductId = 2,
                            Code = "ASD456",
                            Name = "Net",
                            Price = "15.55",
                            ReleaseDate = new DateTime(2021, 4, 9, 20, 50, 21, 752, DateTimeKind.Local).AddTicks(7083)
                        },
                        new
                        {
                            ProductId = 3,
                            Code = "ZXC789",
                            Name = "Ball",
                            Price = "$2.00",
                            ReleaseDate = new DateTime(2021, 4, 9, 20, 50, 21, 752, DateTimeKind.Local).AddTicks(7110)
                        });
                });

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("RegistrationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Registrations");

                    b.HasData(
                        new
                        {
                            RegistrationId = 1,
                            CustomerId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            RegistrationId = 2,
                            CustomerId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            RegistrationId = 3,
                            CustomerId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            RegistrationId = 4,
                            CustomerId = 3,
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Technician", b =>
                {
                    b.Property<int>("TechnicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnicianId");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            TechnicianId = 1,
                            Email = "gowther@georgebrown.ca",
                            Name = "Gowther Kangman",
                            Phone = "416-854-0113"
                        },
                        new
                        {
                            TechnicianId = 2,
                            Email = "tiny.tony@gmail.com",
                            Name = "Tiny Tony",
                            Phone = "4167542904"
                        },
                        new
                        {
                            TechnicianId = 3,
                            Email = "duc.mihn@yahoo.com",
                            Name = "Duc Mihn",
                            Phone = "4167125209"
                        });
                });

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Incident", b =>
                {
                    b.HasOne("GBCSporting2021__TEAM_MYK_.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021__TEAM_MYK_.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GBCSporting2021__TEAM_MYK_.Models.Registration", b =>
                {
                    b.HasOne("GBCSporting2021__TEAM_MYK_.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021__TEAM_MYK_.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
