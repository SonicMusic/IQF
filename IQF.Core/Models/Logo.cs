
namespace IQF.Core.Models
{
    public class Logo : Image
    {
        public Teams? Team { get; set; }
        public Guid TeamId { get; set; }
    }
}
