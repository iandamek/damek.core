using FluentResults;

namespace Damek.Core.Domain.Interfaces
{
    public interface IRepository
    {
    }

    public interface IRepository<TModel> : IRepository
        where TModel : IModel
    {
        TModel GetById(object id);
        TModel GetById(params object[] id);
        Result Insert(params TModel[] model);
        Result Update(params TModel[] model);
        Result Delete(params TModel[] model);
        Result Delete(params object[] id);
        Result SaveChanges();
    }
}
