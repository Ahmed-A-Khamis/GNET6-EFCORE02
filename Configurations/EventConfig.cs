using GNET6_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET6_EFCORE02.Configurations
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> Events)
        {
            Events.HasMany<Event>(e => e.Events).WithOne(e => e.ParentEvent).HasForeignKey(e => e.ParentEventId).OnDelete(DeleteBehavior.NoAction);
            Events.Property<DateTime>("CreatedAt").HasDefaultValueSql("GetDate()");
            Events.Property<DateTime>("LastModifiedAt").HasDefaultValueSql("GetDate()");
        }
    }
}
