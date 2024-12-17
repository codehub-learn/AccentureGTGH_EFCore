using AccentureGTGH_EFCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

//Author eco = new Author()
//{
//    FirstName = "Umberto",
//    LastName = "Eco"
//};

//Genre novel = new Genre()
//{
//    Name = "Novel",
//    Fiction = true
//};

//Genre mystery = new Genre()
//{
//    Name = "Mystery",
//    Fiction = true
//};

//Synopsis pendulumSynopsis = new()
//{
//    WriterFirstName = "John",
//    WriterLastName = "Smith"
//};

//Book pendulum = new Book()
//{
//    Title = "Foucault's Pendulum 4",
//    PubDate = DateTime.Now,
//    Pages = 500,
//    Author = eco,
//    Synopsis = pendulumSynopsis
//};

//pendulum.Genres.Add(novel);
//pendulum.Genres.Add(mystery);

using BooksContext context = new BooksContext();
//context.Books.Add(pendulum);
//context.SaveChanges();

var books = context.Books.ToList();
var authors = context.Authors.ToList();

foreach (Book book in books)
{
    Console.WriteLine(book.Title);
}

Book book1 = context.Books.Find(3);
Console.WriteLine($"Book 1 title is {book1.Title}");

List<Book> pendulums = context.Books
    .Where(b => b.Title.StartsWith("Foucault's Pendulum") || b.Title == "The Name of the Rose")
    .ToList();

Book? book3 = context.Books.Where(b => b.Title.StartsWith("Foucault's Pendulum 10"))
    .FirstOrDefault();

Book? book4 = context.Books.Where(b => b.Title.StartsWith("Foucault's Pendulum 2"))
    .SingleOrDefault();

Book? book5 = context.Books.Where(b => b.Title.StartsWith("Foucault's Pendulum"))
    .Include(b => b.Author)
    .ThenInclude(a => a.Publishers)
    .Include(b => b.Synopsis)
    .OrderBy(b => b.Title)
    .ThenBy(b => b.Pages)
    .ThenBy(b => b.AuthorId)
    .LastOrDefault();

Console.WriteLine("End of application");
