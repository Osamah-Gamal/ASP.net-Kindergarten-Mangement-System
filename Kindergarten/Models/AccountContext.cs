using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Models
{
    public class AccountContext:DbContext
    {

        public AccountContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Signup> Users { get; set; }
    }
}
