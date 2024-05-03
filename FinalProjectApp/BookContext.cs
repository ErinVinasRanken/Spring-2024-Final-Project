 using Microsoft.EntityFrameworkCore;
using System;

namespace FinalProjectApp
{
    public class BookContext : DbContext
    {
        public BookContext() { }    // No-Arg Constructor

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        // Create DbSet for Books and Reviews tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BooksFinal;Integrated security=True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add seed data to Books table
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId      = 1,
                    Isbn        = "5897",
                    AuthorName  = "Sylvia Plath",
                    BookName    = "The Bell Jar",
                    PublishYear = 1963,
                    Img         = @"C:\Users\rinla\Desktop\AWD Photos\The Bell Jar.jpg"
                },

                new Book
                {
                    BookId = 2,
                    Isbn = "5897",
                    AuthorName = "Sylvia Plath",
                    BookName = "Lady Lazarus",
                    PublishYear = 1965,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Lady Lazarus.jpg"
                },

                new Book
                {
                    BookId = 3,
                    Isbn = "5897",
                    AuthorName = "Sylvia Plath",
                    BookName = "Ariel",
                    PublishYear = 1965,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Ariel.jpg"
                },

                new Book
                {
                    BookId = 4,
                    Isbn = "5897",
                    AuthorName = "Sylvia Plath",
                    BookName = "Sylvia Plath: Poems",
                    PublishYear = 1985,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Poems.jpg"
                },

                new Book
                {
                    BookId = 5,
                    Isbn = "5897",
                    AuthorName = "Sylvia Plath",
                    BookName = "Journals of Sylvia Plath",
                    PublishYear = 1982,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Journals of Sylvia Plath.jpg"
                },

                new Book
                {
                    BookId = 6,
                    Isbn = "5897",
                    AuthorName = "Sylvia Plath",
                    BookName = "Tulips",
                    PublishYear = 1965,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Tulips.jpg"
                },

                new Book
                {
                    BookId = 7,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "The Namesake",
                    PublishYear = 2003,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\The Namesake.jpg"
                },

                new Book
                {
                    BookId = 8,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "Interpreter of Maladies",
                    PublishYear = 1999,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Interpreter of Maladies.jpg"
                },

                new Book
                {
                    BookId = 9,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "Unaccustomed Earth",
                    PublishYear = 2008,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Unaccustomed Earth.jpg"
                },

                new Book
                {
                    BookId = 10,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "Roman Stories",
                    PublishYear = 2023,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Roman Stories.jpg"
                },

                new Book
                {
                    BookId = 11,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "The Lowland",
                    PublishYear = 2013,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\The Lowland.jpg"
                },

                new Book
                {
                    BookId = 12,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "Whereabouts",
                    PublishYear = 2018,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Whereabouts.jpg"
                },

                new Book
                {
                    BookId = 13,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "The Other Words",
                    PublishYear = 2015,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\In Other Words.jpg"
                },

                new Book
                {
                    BookId = 14,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "Hell-Heaven",
                    PublishYear = 2015,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Hell-Heaven.jpeg"
                },

                new Book
                {
                    BookId = 15,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "Only Goodness",
                    PublishYear = 2013,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Only Goodness.jpg"
                },

                new Book
                {
                    BookId = 16,
                    Isbn = "8367",
                    AuthorName = "Jhumpa Lahiri",
                    BookName = "The Clothing of Books",
                    PublishYear = 2016,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\The Clothing of Books.jpg"
                },

                new Book
                {
                    BookId = 17,
                    Isbn = "1648",
                    AuthorName = "Stephen King",
                    BookName = "It",
                    PublishYear = 1986,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\IT.jpg"
                },

                new Book
                {
                    BookId = 18,
                    Isbn = "1648",
                    AuthorName = "Stephen King",
                    BookName = "The Shining",
                    PublishYear = 1977,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\The Shining.jpg"
                },

                new Book
                {
                    BookId = 19,
                    Isbn = "1648",
                    AuthorName = "Stephen King",
                    BookName = "Holly",
                    PublishYear = 2023,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Holly.jpg"
                },

                new Book
                {
                    BookId = 20,
                    Isbn = "1648",
                    AuthorName = "Stephen King",
                    BookName = "Carrie",
                    PublishYear = 1974,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Carrie.jpg"
                },

                new Book
                {
                    BookId = 21,
                    Isbn = "1648",
                    AuthorName = "Stephen King",
                    BookName = "The Stand",
                    PublishYear = 1978,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\The Stand.jpg"
                },

                new Book
                {
                    BookId = 22,
                    Isbn = "1648",
                    AuthorName = "Stephen King",
                    BookName = "Misery",
                    PublishYear = 1987,
                    Img = @"C:\Users\rinla\Desktop\AWD Photos\Misery.jpg"
                }
            );

        }
    }
}
