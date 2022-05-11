using Damek.Core.Domain.Interfaces;

namespace Damek.Core.Domain.Models
{
    public abstract class Model : IModel
    { }

    public abstract class Model<TId> : Model, IModel<TId>
    {
        public TId Id { get; set; }
    }
}
