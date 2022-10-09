using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomersProducts.Models;

namespace CustomersProducts.Data
{
    public class CustomersProductsContext : DbContext
    {
        public CustomersProductsContext (DbContextOptions<CustomersProductsContext> options)
            : base(options)
        {
        }

        public DbSet<CustomersProducts.Models.Customer> Customer { get; set; } = default!;

        public DbSet<CustomersProducts.Models.PlacedOrder> PlacedOrder { get; set; }

        public DbSet<CustomersProducts.Models.Product> Product { get; set; }

        public DbSet<CustomersProducts.Models.Item> Item { get; set; }
    }
}
