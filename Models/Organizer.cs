namespace GNET6_EFCORE02.Models
{
    public class Organizer
    {
        public int OrganizerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Company { get; set; } = "";
        public bool IsVerified { get; set; } = false;
        public OrganizerProfile OrganizerProfile { get; set; }
        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
