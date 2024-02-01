using Microsoft.EntityFrameworkCore;

namespace Lutfee6510110408.Components.data
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Book {  get; set; }

        public BookDbContext(DbContextOptions options) : base(options)
        { 
        }
    }
}

