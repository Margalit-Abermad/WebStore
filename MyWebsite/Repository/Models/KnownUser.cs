using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class KnownUser
    {
        public KnownUser()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string SavedCreditCard { get; set; } = null!;

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
