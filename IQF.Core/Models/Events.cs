
namespace IQF.Core.Models
{
    public class Events
    {
        public Guid Id { get; set; }

        public Guid RoomId { get; set; }
        public Rooms? Room { get; set;}

        public List<Games> Games { get; set; } = [];

    }
}
