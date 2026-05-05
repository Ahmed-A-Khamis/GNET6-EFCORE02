namespace GNET6_EFCORE02.Models
{
    public class Registration
    {
        public Event Event { get; set; }
        public int EventId { get; set; }
        public Attendee Attendee { get; set; }
        public int UserId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Note { get; set; } = "";
    }
}
