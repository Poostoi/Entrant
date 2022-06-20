using System;
using Enrollee.Domain.Models;
using Enrollee.Domain.Models.AboutOfEntrant;
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
            var entityTypeBuilder = modelBuilder.Entity(model);
            
            if (model.BaseType == typeof(BaseModel))
            {
                entityTypeBuilder.HasKey("Id");
                entityTypeBuilder.HasBaseType(typeof(BaseModel));
            }
        }
        modelBuilder
            .Entity<Entrant>()
            .HasOne(e => e.MaritalStatus)
            .WithOne(m => m.Entrant)
            .HasForeignKey<Entrant>(p => p.MaritalStatusId);
        modelBuilder
            .Entity<Entrant>()
            .HasOne(e => e.Education)
            .WithOne(m => m.Entrant)
            .HasForeignKey<Entrant>(p => p.EducationId);
        modelBuilder
            .Entity<Entrant>()
            .HasOne(e => e.PassportData)
            .WithOne(m => m.Entrant)
            .HasForeignKey<Entrant>(p => p.PassportDataId);
        modelBuilder
            .Entity<EntrantAddress>()
            .HasOne(e => e.Country)
            .WithOne(m => m.EntrantAddress)
            .HasForeignKey<EntrantAddress>(p => p.CountryId);
        modelBuilder
            .Entity<Entrant>()
            .HasOne(e => e.EntrantAddress)
            .WithOne(m => m.Entrant)
            .HasForeignKey<Entrant>(p => p.EntrantAddressId);
    }
}
