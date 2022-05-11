using AutoMapper;
using Damek.Core.Application.Interfaces;
using Damek.Core.Domain.Interfaces;
using FluentResults;

namespace Damek.Core.Application.Services
{
    public class Service : IService
    {
        protected readonly IUser _user;
        protected readonly IMapper _mapper;

        public Service(IUser user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }
    }
    public class Service<TRepository> : Service
       where TRepository : IRepository
    {
        protected readonly TRepository _repository;

        public Service(TRepository repository, IUser user, IMapper mapper) : base(user, mapper)
        {
            _repository = repository;
        }
    }
}
