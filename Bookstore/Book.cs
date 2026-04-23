using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    #region Answer 1: Create Entities
    public class Book
    {
        public int Id { get; set; } // Primary Key by convention

        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearPublished { get; set; }
        public bool InStock { get; set; }

        // Relationships
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    } 
    #endregion
}
