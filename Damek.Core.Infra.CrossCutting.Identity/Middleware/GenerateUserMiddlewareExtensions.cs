using Damek.Core.Domain.Interfaces;
using Microsoft.AspNetCore.Builder;

namespace Damek.Core.Infra.CrossCutting.Identity.Middleware
{
    public static class GenerateUserMiddlewareExtensions
    {
        public static IApplicationBuilder UseGenerateUser<TUser>(this IApplicationBuilder builder) where TUser : IUser
            => builder.UseMiddleware<GenerateUserMiddleware<TUser>>();
    }
}
