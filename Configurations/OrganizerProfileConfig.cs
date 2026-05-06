using GNET6_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET6_EFCORE02.Configurations
{
    public class OrganizerProfileConfig : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> OrganizerProfile)
        {
            OrganizerProfile.ToTable("OrganizersProfiles").HasKey(op => op.OrganizerId);
            OrganizerProfile.HasOne<Organizer>(op => op.Organizer).WithOne(o => o.OrganizerProfile).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
