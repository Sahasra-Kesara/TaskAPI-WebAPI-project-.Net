﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    partial class TodoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2024, 11, 11, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9762),
                            Description = "For school",
                            Due = new DateTime(2024, 11, 16, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9772),
                            Status = 0,
                            Title = "Get books - DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Created = new DateTime(2024, 11, 11, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9781),
                            Description = "For Son school",
                            Due = new DateTime(2024, 11, 16, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9781),
                            Status = 0,
                            Title = "Get Pens"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Created = new DateTime(2024, 11, 11, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9783),
                            Description = "For office",
                            Due = new DateTime(2024, 11, 16, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9783),
                            Status = 0,
                            Title = "Get Files"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "1",
                            City = "City 01",
                            FullName = "Sahasra Kesara",
                            JobRole = "Frontend Developer",
                            Street = "Street 01"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "2",
                            City = "City 02",
                            FullName = "Nadeera Deshan",
                            JobRole = "Backend Developer",
                            Street = "Street 02"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "3",
                            City = "City 03",
                            FullName = "Viruna Fernando",
                            JobRole = "Software Architect",
                            Street = "Street 03"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "4",
                            City = "City 04",
                            FullName = "Hansi Nimasha",
                            JobRole = "Full Stack Developer",
                            Street = "Street 04"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
