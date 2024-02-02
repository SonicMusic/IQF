
namespace IQF.Core.Models
{
    public class RoomProfiles
    {
        public Guid ProfilesId { get; set; }
        public Profiles? Profile { get; set; }

        public Guid RoomsId { get; set; }
        public Rooms? Room { get; set; }

        public int Points { get; set; }
    }
}
