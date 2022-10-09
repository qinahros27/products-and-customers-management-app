using System;
using System.Collections.Generic;

namespace CustomersProducts.Models
{
    public partial class Product
    {
        public Product()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; } = null!;

        public virtual ICollection<Item>? Items { get; set; }
    }
}
