
namespace IQF.Core.Models
{
    public class Image
    {
        public Guid Id { get; set; }

        public string FileName { get; set; } = string.Empty;

        public FileStream? FileStream { get; set; }
    }
}
