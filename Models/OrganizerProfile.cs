namespace GNET6_EFCORE02.Models
{
    public class OrganizerProfile
    {
        public Organizer Organizer { get; set; }
        public int OrganizerId { get; set; }
        public string Link { get; set; } = "";
        public string Bio { get; set; } = "";
        public string LogoUrl { get; set; } = "https://placehold.co/600x400?text=%3C/%3E";
    }
}
