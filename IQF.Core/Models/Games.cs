
namespace IQF.Core.Models
{
    public class Games
    {
        public Guid Id { get; set; }

        public Events? Event { get; set; }
        public Guid EventId { get; set; }

        public List<Teams> Teams { get; set; } = [];
        

        public DateTime? StartMatch { get; set; }

        public bool IsFinished { get; set; }

    }
}
