
namespace Damek.Core.Domain.Interfaces
{
    public interface IModel
    {
    }
    public interface IModel<TId> : IModel
    {
        TId Id { get; set; }
    }
}
