using Microsoft.EntityFrameworkCore;
using Wired.Data.Entities;

namespace Wired.Data.Context
{
    public class WiredContext : DbContext
    {

        public WiredContext(DbContextOptions<WiredContext> options)
          : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
