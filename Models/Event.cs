namespace GNET6_EFCORE02.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxAttendees { get; set; } = 0;
        public Organizer Organizer { get; set; }
        public int OrganizerId { get; set; }

        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
        public Event? ParentEvent { get; set; }
        public int ParentEventId { get; set; }

    }
}
