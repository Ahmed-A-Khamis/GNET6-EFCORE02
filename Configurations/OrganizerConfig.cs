using GNET6_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET6_EFCORE02.Configurations
{
    public class OrganizerConfig : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> Organizers)
        {
            Organizers.HasKey(o => o.OrganizerId);
            Organizers.HasMany<Event>(o => o.Events).WithOne(e => e.Organizer).HasForeignKey(e => e.OrganizerId).OnDelete(DeleteBehavior.Cascade);
            Organizers.HasOne<OrganizerProfile>(o => o.OrganizerProfile).WithOne(op => op.Organizer);
        }
    }
}
