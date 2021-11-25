using Microsoft.EntityFrameworkCore;

namespace StartApp.Infrastructure.Contexts
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}