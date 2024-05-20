using Microsoft.EntityFrameworkCore;
using models;

namespace data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "1984",
                Author = "George Orwell",
                Genre = "Dystopian",
                ISBN = "9780451524935"
            },
            new Book
            {
                Id = 2,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                ISBN = "9780061120084"
            },
            new Book
            {
                Id = 3,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Classics",
                ISBN = "9780743273565"
            },
            new Book
            {
                Id = 4,
                Title = "Moby Dick",
                Author = "Herman Melville",
                Genre = "Adventure",
                ISBN = "9781503280786"
            },
            new Book
            {
                Id = 5,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Genre = "Romance",
                ISBN = "9781503290563"
            }
        );
    }
}