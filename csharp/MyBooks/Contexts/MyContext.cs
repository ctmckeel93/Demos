using Microsoft.EntityFrameworkCore;
using MyBooks.Models;

namespace MyBooks.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
            public DbSet<User> Users {get;set;}
            public DbSet<Book> Books {get;set;}
            public DbSet<Bookshelf> BookCollections {get;set;}
    }
}