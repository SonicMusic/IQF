
using IQF.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IQF.DataAccess.Configurations
{
    public class GamesConfiguration : IEntityTypeConfiguration<Games>
    {
        public void Configure(EntityTypeBuilder<Games> builder)
        {
            builder.HasKey(g => g.Id);

            //Связь один ко многим.
            builder.
                HasOne(g => g.Event).
                WithMany(e => e.Games).
                HasForeignKey(g => g.EventId);

        }
    }
}
