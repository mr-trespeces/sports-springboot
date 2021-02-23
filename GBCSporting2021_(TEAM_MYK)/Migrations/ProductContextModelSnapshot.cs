﻿// <auto-generated />
using GBCSporting2021__TEAM_MYK_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GBCSporting2021__TEAM_MYK_.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Code = "QWE123",
                            Name = "YP",
                            Price = "$999.99",
                            ReleaseDate = "10/23/1996"
                        },
                        new
                        {
                            ProductId = 2,
                            Code = "ASD456",
                            Name = "Mark",
                            Price = "$555.55",
                            ReleaseDate = "2/11/1997"
                        },
                        new
                        {
                            ProductId = 3,
                            Code = "ZXC789",
                            Name = "Kent",
                            Price = "$2.00",
                            ReleaseDate = "6/2/1963"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
