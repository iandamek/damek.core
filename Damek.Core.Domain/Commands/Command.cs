using Damek.Core.Domain.Interfaces;

namespace Damek.Core.Domain.Commands
{
    public abstract class Command : IModel
    { }

    public abstract class Command<TId> : Command, ICommand<TId>
    {
        public TId Id { get; set; }
    }
}
