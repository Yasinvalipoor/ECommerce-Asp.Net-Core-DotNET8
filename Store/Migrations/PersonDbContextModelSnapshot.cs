﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Models;

#nullable disable

namespace Store.Migrations
{
    [DbContext(typeof(PersonDbContext))]
    partial class PersonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Store.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoryCustomers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Yasin",
                            LastName = "ValiPour",
                            categoryCustomers = "Golden"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Ali",
                            LastName = "Hafezi",
                            categoryCustomers = "Golden"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "MohammadReza",
                            LastName = "Sohrablo",
                            categoryCustomers = "Golden"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Ali",
                            LastName = "Hasani",
                            categoryCustomers = "Golden"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Radin",
                            LastName = "Mahfozian",
                            categoryCustomers = "Bronze"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Parsa",
                            LastName = "Mohammadi",
                            categoryCustomers = "Bronze"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Parsa",
                            LastName = "Khezli",
                            categoryCustomers = "Simple"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Nima",
                            LastName = "tarhani",
                            categoryCustomers = "Simple"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Ali",
                            LastName = "Mashhadi",
                            categoryCustomers = "Simple"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Omid",
                            LastName = "Asadi",
                            categoryCustomers = "Simple"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
