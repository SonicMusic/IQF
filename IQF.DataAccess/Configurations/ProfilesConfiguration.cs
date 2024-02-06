
using IQF.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IQF.DataAccess.Configurations
{
    public class ProfilesConfiguration : IEntityTypeConfiguration<Profiles>
    {
        public void Configure(EntityTypeBuilder<Profiles> builder)
        {
            builder.HasKey(p => p.Id);

            // Связь один к одному.
            builder.
                HasOne(p => p.User).
                WithOne(u => u.Profile).
                HasForeignKey<Profiles>(p  => p.UsersId);

            //Связь многие ко многим.
            builder.
                HasMany(p => p.Rooms).
                WithMany(r => r.Profiles);

            //Связь один ко многим.
            builder.
                HasMany(p => p.RoomProfiles).
                WithOne(rp => rp.Profile).
                HasForeignKey(rp => rp.ProfilesId);
        }
    }
}
