
namespace Damek.Core.Domain.Interfaces
{
    public interface ICommand
    {
    }
    public interface ICommand<TId> : IModel
    {
        TId Id { get; set; }
    }
}
