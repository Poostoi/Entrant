using System;
using Enrollee.Domain.Models;
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
        modelBuilder.Entity<BaseModel>().HasKey(x => x.Id);

        foreach (var model in _entityProvider.GetModels())
        {
            var entityTypeBuilder = modelBuilder.Entity(model);
        }
        
        modelBuilder.Entity<Account>().HasBaseType<BaseModel>();
        modelBuilder.Entity<Account>()
            .HasMany(a => a.Roles)
            .WithMany(t => null!)
            .UsingEntity(acR => acR.ToTable("AccountRole"));
        
    }
}
