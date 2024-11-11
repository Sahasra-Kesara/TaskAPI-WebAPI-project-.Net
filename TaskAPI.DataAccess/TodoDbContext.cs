using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=MyTodoDb; User Id='';Password=''; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<author>().HasData(new author[]
            {
                new author {Id = 1, FullName = "Sahasra Kesara", AddressNo = "1", Street = "Street 01", City = "City 01", JobRole = "Frontend Developer"},
                new author {Id = 2, FullName = "Nadeera Deshan", AddressNo = "2", Street = "Street 02", City = "City 02", JobRole = "Backend Developer"},
                new author {Id = 3, FullName = "Viruna Fernando", AddressNo = "3", Street = "Street 03", City = "City 03", JobRole = "Software Architect"},
                new author {Id = 4, FullName = "Hansi Nimasha", AddressNo = "4", Street = "Street 04", City = "City 04", JobRole = "Full Stack Developer"},
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
            new Todo
            {
                Id = 1,
                Title = "Get books - DB",
                Description = "For school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1,
            },
            new Todo
            {
                Id = 2,
                Title = "Get Pens",
                Description = "For Son school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1,
            },
            new Todo
            {
                Id = 3,
                Title = "Get Files",
                Description = "For office",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 2,
            },
            });
        }
    }
}
