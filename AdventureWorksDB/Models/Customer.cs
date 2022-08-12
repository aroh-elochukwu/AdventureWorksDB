namespace AdventureWorksDB.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyName { get; set; }
        public long? PhoneNumber { get; set; }
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();

    }
}
