using System;

namespace FinalProjectApp
{
    public class Book
    {
        public int BookId { get; set; } // Primary key
        public string? Isbn { get; set; }
        public string? AuthorName { get; set; }
        public string? BookName { get; set; }
        public int? PublishYear { get; set; }
        public string? Img { get; set; }

        // No-Arg Constructor
        public Book() { }
    }
}
