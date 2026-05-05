using GNET6_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET6_EFCORE02.Configurations
{
    public class RegistrationConfig : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> Registrations)
        {
            Registrations.HasKey(r => new
            {
                r.EventId,
                r.UserId
            });
            Registrations.HasOne(r => r.Event).WithMany(e => e.Registrations).HasForeignKey(r => r.EventId);
            Registrations.HasOne(r => r.Attendee).WithMany(e => e.Registrations).HasForeignKey(r => r.UserId);
        }
    }
}
