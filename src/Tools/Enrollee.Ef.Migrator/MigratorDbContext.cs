using Enrollee.Infrastructure.Contexts;
using Enrollee.Infrastructure.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Enrollee.Ef.Migrator;

internal sealed class MigratorDbContext : ServerDbContext
{
    private readonly ILoggerFactory _loggerFactory;

    public MigratorDbContext(
        DbContextOptions options,
        EntityProvider entityProvider,
        ILoggerFactory loggerFactory)
        : base(options, entityProvider)
    {
        _loggerFactory = loggerFactory;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseLoggerFactory(_loggerFactory);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
                
        builder.HasPostgresExtension("uuid-ossp");
                
        DataSeedingProvider.Config(builder);
    }
}
