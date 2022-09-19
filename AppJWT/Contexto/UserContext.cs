using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AppJWT.Models;
using Microsoft.EntityFrameworkCore;

namespace AppJWT.Contexto
{
    public class UserContext : IdentityDbContext<User>
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
    }
}

