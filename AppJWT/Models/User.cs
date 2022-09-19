using Microsoft.AspNetCore.Identity;

namespace AppJWT.Models
{
    public class User: IdentityUser
    {
        public string UserNombre { get; set; } = default!;
        public string UserApellido { get; set; } = default!;

    }
}
