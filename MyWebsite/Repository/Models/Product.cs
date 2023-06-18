using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public int Department { get; set; }

        public virtual Department DepartmentNavigation { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
