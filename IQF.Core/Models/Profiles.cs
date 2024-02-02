

namespace IQF.Core.Models
{
    public class Profiles
    {
        public Guid Id { get; set; }

        public Guid UsersId { get; set; }
        public Users? User { get; set; }

        public Avatar? Avatar { get; set; }

        public List<Rooms> Rooms { get; set; } = [];

        public List<RoomProfiles> RoomProfiles { get; set; } = [];

    }
}
