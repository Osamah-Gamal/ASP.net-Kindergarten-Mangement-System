using Microsoft.EntityFrameworkCore;
using Kid.Models.DBS;

namespace Kid.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
