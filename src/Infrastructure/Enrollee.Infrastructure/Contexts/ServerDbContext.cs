using System;
using Enrollee.Infrastructure.Provider;
using Microsoft.EntityFrameworkCore;

namespace Enrollee.Infrastructure.Contexts;

internal class ServerDbContext : DbContext
{
    private readonly EntityProvider _entityProvider;

    public ServerDbContext(DbContextOptions options, EntityProvider entityProvider) 
        : base(options)
    {
        ArgumentNullException.ThrowIfNull(entityProvider);

        _entityProvider = entityProvider;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        foreach (var model in _entityProvider.GetModels())
        {
            modelBuilder.Entity(model);
        }
    }
}
