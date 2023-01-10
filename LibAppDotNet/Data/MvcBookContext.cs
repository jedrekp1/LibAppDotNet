using LibAppDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace LibAppDotNet.Data
{
    public class MvcBookContext : DbContext
    {

        public MvcBookContext(DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

    }
}
