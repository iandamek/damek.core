using Damek.Core.Domain.Interfaces;
using MongoDB.Driver;

namespace Damek.Core.Infra.MongoDb.Contexts
{
    public interface IContext
    {
        IMongoCollection<TModel> GetCollection<TModel>(string collectionName = null) where TModel : IModel;
    }
}
