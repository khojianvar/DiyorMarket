﻿using DiyorMarket.Domain.Common;

namespace DiyorMarket.Domain.Entities
{
    public class Supplier : EntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }

        public virtual ICollection<Supply> Supplies { get; set; }
    }
}
