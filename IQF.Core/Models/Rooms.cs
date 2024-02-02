       
namespace IQF.Core.Models
{
    public class Rooms
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Profiles> Profiles { get; set; } = [];

        public List<RoomProfiles> RoomProfiles { get; set; } = [];

        public List<Events> Events { get; set; } = [];
    }
}
