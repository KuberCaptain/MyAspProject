using Microsoft.EntityFrameworkCore;
using MyProject.Models; 

namespace MyProject.Data
{
    public class MyBookDbContext : DbContext
    {
        public MyBookDbContext(DbContextOptions<MyBookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
