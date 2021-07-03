namespace MyBooks.Models
{
    public class Bookshelf
    {
        public int BookshelfId { get; set; }

        public int UserId { get; set; }
        public int BookId { get; set; }

        public User Reader { get; set; }

        public Book UserBook { get; set; }
    }
}