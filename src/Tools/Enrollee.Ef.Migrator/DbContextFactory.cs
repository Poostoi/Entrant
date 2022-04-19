using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using Enrollee.Infrastructure.Provider;

namespace Enrollee.Ef.Migrator;

internal class DbContextFactory : IDesignTimeDbContextFactory<MigratorDbContext>
{
    private readonly ILoggerFactory _loggerFactory;

    public DbContextFactory(ILoggerFactory loggerFactory)
    {
        _loggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
    }

    public MigratorDbContext CreateDbContext(string[] args)
    {
        var configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .AddJsonFile($"appsettings.{Program.EnvironmentName}.json", true)
            .AddJsonFile("appsettings.local.json", true);

        var configuration = configurationBuilder.Build();

        var dbContextOptions = new DbContextOptionsBuilder()
            .UseNpgsql(configuration["DbConnection"], 
                o => o.MigrationsAssembly(GetType().Namespace)
                    .MigrationsHistoryTable(HistoryRepository.DefaultTableName, "service"))
            .Options;

        var entityProvider = new EntityProvider();
        return new MigratorDbContext(dbContextOptions, entityProvider, _loggerFactory);
    }
}
