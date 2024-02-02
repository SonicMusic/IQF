
using IQF.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IQF.DataAccess.Configurations
{
    public class RoomProfilesConfiguration : IEntityTypeConfiguration<RoomProfiles>
    {
        public void Configure(EntityTypeBuilder<RoomProfiles> builder)
        {
            //Связь один ко многим.
            builder.
                HasOne(rp => rp.Room).
                WithMany(r => r.RoomProfiles).
                HasForeignKey(rp => rp.RoomsId);

            //Связь один ко многим.
            builder.
                HasOne(rp => rp.Profile).
                WithMany(p => p.RoomProfiles).
                HasForeignKey(rp => rp.ProfilesId);
        }
    }
}
