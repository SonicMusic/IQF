
using IQF.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IQF.DataAccess.Configurations
{
    public class RoomsConfiguration : IEntityTypeConfiguration<Rooms>
    {
        public void Configure(EntityTypeBuilder<Rooms> builder)
        {
            builder.HasKey(p => p.Id);

            //Связь многие ко многим.
            builder.
                HasMany(r => r.Profiles).
                WithMany(p => p.Rooms);

            //Связь один ко многим.
            builder.
                HasMany(r => r.RoomProfiles).
                WithOne(rp => rp.Room).
                HasForeignKey(rp => rp.RoomsId);

            //Связь один ко многим.
            builder.
                HasMany(r => r.Events).
                WithOne(e => e.Room).
                HasForeignKey(e => e.RoomId);

        }
    }
}
