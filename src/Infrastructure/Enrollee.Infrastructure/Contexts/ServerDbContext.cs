using System;
using Enrollee.Domain.Models;
using Enrollee.Domain.Models.AboutOfEntrant;
using Enrollee.Domain.Models.User;
using Enrollee.Domain.Models.Vacancy;
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
                entityTypeBuilder.HasBaseType(typeof(BaseModel));
            }
            
        }
        modelBuilder.Ignore<BaseModel>();
        modelBuilder.Entity<Destrict>().ToTable("Districts");
        modelBuilder.Entity<EntrantAddress>().ToTable("EntrantAddress");
        modelBuilder.Entity<Place>().ToTable("Places");
        modelBuilder.Entity<Region>().ToTable("Regions");
        modelBuilder.Entity<Faculty>().ToTable("Faculties");
        modelBuilder.Entity<Language>().ToTable("Languages");
        modelBuilder.Entity<Speciality>().ToTable("Specialties");
        modelBuilder.Entity<Vacancy>().ToTable("Vacancies");
        modelBuilder.Entity<Account>().ToTable("Accounts");
        modelBuilder.Entity<Role>().ToTable("Roles");
        modelBuilder.Entity<Education>().ToTable("Educations");
        modelBuilder.Entity<Entrant>().ToTable("Entrants");
        modelBuilder.Entity<MaritalStatus>().ToTable("MaritalStatus");
        modelBuilder.Entity<PassportData>().ToTable("PassportData");
        modelBuilder.Entity<Nationality>().ToTable("Nationalities");
        modelBuilder.Entity<Country>().ToTable("Countries");
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
