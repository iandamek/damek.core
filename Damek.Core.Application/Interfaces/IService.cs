using Damek.Core.Domain.Interfaces;

namespace Damek.Core.Application.Interfaces
{
    public interface IService
    {
    }
    public interface IService<TModel, TViewModel> : IService
        where TModel : IModel
        where TViewModel : IViewModel
    {

    }
}
