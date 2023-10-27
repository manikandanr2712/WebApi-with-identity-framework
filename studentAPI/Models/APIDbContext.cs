using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studentAPI.Entity;

namespace studentAPI.Models
{
    //public class APIDbContext : DbContext
    public class APIDbContext : IdentityDbContext<User>
    {
        public APIDbContext(DbContextOptions option): base(option) {
        
        }
        public DbSet<Student> student { get; set; }

    }
}
