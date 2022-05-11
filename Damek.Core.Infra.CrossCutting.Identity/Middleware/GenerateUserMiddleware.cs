using Damek.Core.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Damek.Core.Infra.CrossCutting.Identity.Middleware
{
    public class GenerateUserMiddleware<TUser> where TUser : IUser
    {
        private readonly RequestDelegate _next;

        public GenerateUserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, TUser user)
        {
            //if (context != null && context.User != null && context.User.Claims.Any() && context.User.Claims.All(x => x.Value != null))
            //    user.SetProperties(context.User.Claims);

            await _next(context);
        }
    }
}
