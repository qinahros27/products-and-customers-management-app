using System;
using System.Collections.Generic;

namespace CustomersProducts.Models
{
    public partial class Customer
    {
        public Customer()
        {
            PlacedOrders = new HashSet<PlacedOrder>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<PlacedOrder>? PlacedOrders { get; set; }
    }
}
