using coredemowebsite.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace coredemowebsite.Data
{
    public class blogDbContext : DbContext
    {
        public blogDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
