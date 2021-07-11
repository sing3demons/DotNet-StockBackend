using System;
using System.Collections.Generic;

namespace StockBackend.Models
{
    public  class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}