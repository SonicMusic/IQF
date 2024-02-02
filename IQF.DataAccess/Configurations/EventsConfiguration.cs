
using IQF.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IQF.DataAccess.Configurations
{
    public class EventsConfiguration : IEntityTypeConfiguration<Events>
    {
        public void Configure(EntityTypeBuilder<Events> builder)
        {
            builder.HasKey(p => p.Id);

            //Связь один ко многим.
            builder.
                HasOne(e => e.Room).
                WithMany(r => r.Events).
                HasForeignKey(e => e.RoomId);

            //Связь один ко многим.
            builder.
                HasMany(e => e.Games).
                WithOne(g => g.Event).
                HasForeignKey(g => g.EventId);
        }
    }
}
