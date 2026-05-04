namespace GNET6_EFCORE02.Models
{
    public class Badge
    {
        public int UserId { get; set; }
        public Attendee Attendee { get; set; }
        public DateTime IssuedDate { get; set; }
        public enum BadgeType
        { Standard, VIP }
    }
}
