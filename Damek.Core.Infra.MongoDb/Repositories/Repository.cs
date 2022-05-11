using Damek.Core.Domain.Interfaces;
using FluentResults;
using System;

namespace Damek.Core.Infra.MongoDb.Repositories
{
    public class Repository : IRepository
    {
    }

    public class Repository<TModel> : Repository, IRepository<TModel>
        where TModel : IModel
    {
        protected readonly IContext _context;

        public Result Delete(params TModel[] model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(params object[] id)
        {
            throw new NotImplementedException();
        }

        public TModel GetById(object id)
        {
            throw new NotImplementedException();
        }

        public TModel GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public Result Insert(params TModel[] model)
        {
            throw new NotImplementedException();
        }

        public Result SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Result Update(params TModel[] model)
        {
            throw new NotImplementedException();
        }
    }
}
