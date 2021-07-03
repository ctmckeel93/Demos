using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBooks.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Author { get; set; }

        public DateTime CreatedAt {get; set; } = DateTime.Now;

        public DateTime UppdatedAt {get; set; } = DateTime.Now;

        public List<Bookshelf> Owners { get; set; }

    }
}