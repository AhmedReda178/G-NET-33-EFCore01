using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore
{
    #region Answer 3: Category Entity
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<Book> Books { get; set; }
    } 
    #endregion
}
