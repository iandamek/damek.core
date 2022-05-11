using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Damek.Core.Infra.CrossCutting.Util
{
    public static class ClaimsExtensions
    {
        public static string GetClaimByType(this IEnumerable<Claim> claims, string type) => (claims.FirstOrDefault(x => x.Type == type)?.Value);
    }
}
