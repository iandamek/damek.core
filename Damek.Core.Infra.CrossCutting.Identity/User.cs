using Damek.Core.Domain.Interfaces;

namespace Damek.Core.Infra.CrossCutting.Identity
{
    public class User : IUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
