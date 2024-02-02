using IQF.Core.Enum;

namespace IQF.Core.Models
{
    public class Users
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public Role Role { get; set; }

        public Profiles? Profile { get; set; }
    }
}
