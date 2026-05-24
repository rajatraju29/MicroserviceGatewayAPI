using AuthService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Persistence
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }  
    }
}
