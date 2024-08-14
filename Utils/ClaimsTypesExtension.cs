using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public static class ClaimsTypesExtension
    {
        
            public static int ObterUsuarioId(this ClaimsPrincipal user)
            {
            var id = 
                user.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        
        return int.Parse(id);
        }
    }
}