
namespace Damek.Core.Domain.Interfaces
{
    public interface IUser
    {
        long Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }
}
