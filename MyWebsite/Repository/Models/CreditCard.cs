using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class CreditCard
    {
        public int UserId { get; set; }
        public string Number { get; set; } = null!;
        public string Cvv { get; set; } = null!;
        public string Validity { get; set; } = null!;
    }
}
