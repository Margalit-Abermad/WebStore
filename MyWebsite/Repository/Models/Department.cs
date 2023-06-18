using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Department
    {
        public Department()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
