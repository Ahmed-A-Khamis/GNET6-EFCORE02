namespace GNET6_EFCORE02.Models
{
    public class Attendee
    {
        public int UserId { get; set; } // must implement it as primary key later
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public string Country { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public Badge? Badge { get; set; }
        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();

    }
}
