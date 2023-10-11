using Ef_practice_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_practice_DataAccess.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<BookDetail> BookDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=NIT0010\\SQLEXPRESS01;Database=Ef_Practice;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            var bookList = new Book[]
            {
                new Book {BookId= 1, Title="Spider without Duty", ISBN="123B12", Price=10.99m, Publisher_Id=1 },
                new Book {BookId= 2, Title="Fortune of Time", ISBN="12123B12", Price=11.99m, Publisher_Id=1 },
                new Book {BookId= 3, Title="Fake Sunday", ISBN="77652", Price=20.99m, Publisher_Id=2 },
                new Book {BookId= 4, Title="Cookie Jar", ISBN="CC12B12", Price=25.99m , Publisher_Id =2 },
                new Book {BookId= 5, Title="Cloudy Forest", ISBN="90392B33", Price=40.99m , Publisher_Id = 3 }
            };
            
            modelBuilder.Entity<Book>().HasData(bookList);

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherId = 1, Name = "Publisher 1 Jimmy", Location = "Chicago" },
                new Publisher { PublisherId = 2, Name = "Publisher 2 John", Location = "New York" },
                new Publisher { PublisherId = 3, Name = "Publisher 3 Ben", Location = "Hawaii" }
                );

        }
    }
}
