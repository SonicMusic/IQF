using IQF.Core.Models;
using IQF.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace IQF.DataAccess
{
    public class IqfDbContext(DbContextOptions<IqfDbContext> options) : DbContext(options)
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Logo> Logo { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<RoomProfiles> RoomProfiles { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Teams> Teams { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new ProfilesConfiguration());
            modelBuilder.ApplyConfiguration(new RoomsConfiguration());
            modelBuilder.ApplyConfiguration(new RoomProfilesConfiguration());
            modelBuilder.ApplyConfiguration(new EventsConfiguration());
            modelBuilder.ApplyConfiguration(new GamesConfiguration());

            base.OnModelCreating(modelBuilder);
        }


    }
}
