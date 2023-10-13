// See https://aka.ms/new-console-template for more information
using EF_practice_DataAccess.Data;
using Ef_practice_Model.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

AddBook();

GetAllBooks();
GetBook();
updateBook();

DeleteBook();

async void DeleteBook()
{
    using var context = new ApplicationDbContext();
    var book = context.Books.Find(6);
    context.Books.Remove(book);
    await context.SaveChangesAsync();
}

async void updateBook()
{
    try
    {
        using var context = new ApplicationDbContext();
        var books = await context.Books.Where(u=>u.Publisher_Id == 1).ToListAsync();
        /*book.Title = "New EF Core 2.0";*/
        foreach(var book in books)
        {
            book.Price = 55.55m;
        }
        await context.SaveChangesAsync();

    } catch { }
}

async void GetBook()
{
    using var context = new ApplicationDbContext();
    /*var book = context.Books.FirstOrDefault(u=>u.Title == "Cookie Jar");*/
    var books = await context.Books.Skip(4).Take(1).ToListAsync();
    /*Console.WriteLine(book.Title + " - " + book.ISBN)*/;
    foreach (var book in books)
    {
        Console.WriteLine(book.Title + " - " + book.ISBN);
    }
}

async void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = await context.Books.ToListAsync();
    foreach (var book in books)
    {
        Console.WriteLine(book.Title + " - " + book.ISBN);
    }
}

async void AddBook()
{
    Book book = new() { Title = "New EF Core Book", ISBN = "999", Price = 10.9m, Publisher_Id = 3 };
    using var context = new ApplicationDbContext();
    var books = await context.Books.AddAsync(book);
    await context.SaveChangesAsync();
}