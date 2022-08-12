﻿namespace AdventureWorksDB.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
    }
}
