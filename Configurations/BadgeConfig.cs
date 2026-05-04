using GNET6_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET6_EFCORE02.Configurations
{
    public class BadgeConfig : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> Badges)
        {
            Badges.ToTable("Badges").HasKey(b => b.UserId);
            Badges.Property(b => b.UserId).ValueGeneratedNever();
            Badges.HasOne(b => b.Attendee)
                  .WithOne(u => u.Badge)
                  .HasForeignKey<Badge>(b => b.UserId)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
