
namespace IQF.Core.Models
{
    public class Teams
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ShortName { get; set; } = string.Empty;

        public Logo? Logo { get; set; }

        public uint GoalsInTheMatch { get; set; }

        public List<Games> Games { get; set; } = [];

    }
}
