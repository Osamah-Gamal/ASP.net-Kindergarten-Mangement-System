using Microsoft.EntityFrameworkCore;

namespace Kindergarten.Models
{
    public class Studentcontext:DbContext
    {
        public Studentcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Items { get; set; }

    }
}
