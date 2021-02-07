using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Wired.Data.Context
{
    class WiredContextFactory : IDesignTimeDbContextFactory<WiredContext>
    {
        public WiredContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WiredContext>();
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\furka\source\repos\Wired\Wired.Data\my.db");

            return new WiredContext(optionsBuilder.Options);
        }
    }
}
