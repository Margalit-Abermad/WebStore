using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductImage { get; set; } = null!;
        public int Count { get; set; }
        public double Price { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual KnownUser User { get; set; } = null!;
    }
}
