namespace GNET6_EFCORE02.Models
{
    public class Organizer
    {
        public int OrganizerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Company { get; set; } = "";
        public bool IsVerified { get; set; } = false;
        public string Link { get; set; } = "";
        public string Bio { get; set; } = "";
        public string LogoUrl { get; set; } = "https://placehold.co/600x400?text=%3C/%3E";
        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
