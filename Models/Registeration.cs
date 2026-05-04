namespace GNET6_EFCORE02.Models
{
    public class Registeration
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Note { get; set; } = "";
    }
}
