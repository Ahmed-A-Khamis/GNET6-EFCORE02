using GNET6_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GNET6_EFCORE02
{
    public class EventHubDbContext : DbContext

    {
        public EventHubDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDb;Trusted_Connection=True;trustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Event> Events { get; set; }
        //public DbSet<Registeration> Registerations { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Attendee> Attendees { get; set; }

    }
}
