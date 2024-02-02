
namespace IQF.Core.Models
{
    public class Games
    {
        public Guid Id { get; set; }

        public Events? Event { get; set; }
        public Guid EventId { get; set; }

        public Teams? TeamHome { get; set; }
        public Guid TeamHomeId { get; set; }

        public Teams? TeamAway { get; set; }
        public Guid TeamAwayId { get; set; }

        public DateTime? StartMatch { get; set; }

        public bool IsFinished { get; set; }

    }
}
