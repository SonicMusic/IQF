
namespace IQF.Core.Models
{
    public class Avatar : Image
    {
        public Guid ProfilesId { get; set; }
        public Profiles? Profile { get; set; }
    }
}
