using GNET6_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET6_EFCORE02.Configurations
{
    public class AttendeeConfig : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> Attendees)
        {
            Attendees.ToTable("Attendees").HasKey(e => e.UserId);
            Attendees.Property(e => e.UserId).UseIdentityColumn();
            Attendees.HasAlternateKey(e => e.Email);
            Attendees.Property(e => e.Name).HasMaxLength(100).IsRequired();
            Attendees.Property(e => e.Email).HasMaxLength(100).IsRequired();
        }
    }
}
