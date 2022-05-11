using Damek.Core.Application.Interfaces;
using Damek.Core.Application.Services;
using Damek.Core.Domain.Interfaces;
using Damek.Core.Infra.CrossCutting.Identity;
using Damek.Core.Infra.EFCore.Contexts;
using Damek.Core.Infra.EFCore.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Damek.Core.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {

        protected NativeInjectorBootStrapper() { }

        public static void RegisterServices(IServiceCollection services)
        {
            DataBaseConfig(services);
            ServicesConfig(services);
            User(services);
        }

        private static void DataBaseConfig(IServiceCollection services)
        {
            services.AddScoped<Context>();
        }

        private static void ServicesConfig(IServiceCollection services)
        {

        }
        private static void RepositoriesConfig(IServiceCollection services)
        {

        }

        private static void User(IServiceCollection services)
        {
            services.AddScoped<IUser, User>();
        }
    }
}
