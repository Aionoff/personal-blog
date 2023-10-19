using Microsoft.EntityFrameworkCore;

namespace Personal_Blog_Backend.Models
{
    public class PageContext: DbContext
    {
        public PageContext(DbContextOptions<PageContext> options)
            : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; } = null!;
    }
}
