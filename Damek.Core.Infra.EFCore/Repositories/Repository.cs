using Damek.Core.Domain.Interfaces;
using Damek.Core.Infra.EFCore.Contexts;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using System;

namespace Damek.Core.Infra.EFCore.Repositories
{
    public class Repository : IRepository
    {
        protected virtual short _pageCounter => 10;

        protected readonly DbContext _db;
        protected readonly IUser _user;

        public Repository(Context context, IUser user)
        {
            _db = context;
            _user = user;
        }
    }

    public class Repository<TModel> : Repository, IRepository<TModel>
        where TModel : class, IModel
    {
        private enum AcaoBulk { Inserir = 0, InserirOuAtualizar = 1, Deletar = 2 };
        protected readonly DbSet<TModel> _dbSet;

        public Repository(Context context, IUser usuario) : base(context, usuario)
        {
            _dbSet = _db.Set<TModel>();
        }

        public TModel GetById(object id)
            => _dbSet.Find(id);

        public TModel GetById(params object[] id)
            => _dbSet.Find(id);

        public Result Insert(params TModel[] model)
        {
            try
            {
                _dbSet.AddRange(model);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Fail(
                    $@"Falha ao inserir.
                    {e.Message}");
            }
        }

        public Result Update(params TModel[] model)
        {
            try
            {
                _dbSet.UpdateRange(model);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Fail(
                    $@"Falha ao salvar.
                    {e.Message}");
            }
        }

        public Result Delete(params TModel[] model)
        {
            try
            {
                _dbSet.RemoveRange(model);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Fail(
                    $@"Falha ao remover os registros.
                    {e.Message}");
            }
        }

        public Result Delete(params object[] id)
        {
            try
            {
                _dbSet.Remove(_dbSet.Find(id));
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Fail(
                    $@"Falha ao remover os registros.
                    {e.Message}");
            }
        }

        public Result SaveChanges()
        {
            try
            {
                _db.SaveChanges();
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Fail(
                    $@"Falha ao salvar as alterações.
                    {e.Message}");
            }
        }
    }
}
