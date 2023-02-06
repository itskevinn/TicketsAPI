using Domain.Entity.Base;
using Infrastructure.Core.Helpers;
using Infrastructure.Persistence.Configuration;
using Infrastructure.Persistence.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context;

public class TicketsContext : DbContext
{
    private readonly AppSettings? _settings;

    public TicketsContext(DbContextOptions<TicketsContext> options,
        AppSettings repoSettings) : base(options)
    {
        _settings = repoSettings;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasSequence("sq_ticket_code");
        modelBuilder.HasDefaultSchema(_settings?.SchemaName);
        SetDefaultValues(modelBuilder);
        EntitiesConfigurator.Configure(modelBuilder);
    }

    private static void SetDefaultValues(ModelBuilder modelBuilder)
    {
        Seeder.GenerateSeeds(modelBuilder);
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var t = entityType.ClrType;
            if (!typeof(DomainEntity).IsAssignableFrom(t)) continue;
            modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedOn").HasDefaultValue(DateTime.Now);
            modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModifiedOn")
                .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity(entityType.Name).Property<string>("LastModifiedBy").IsRequired(false);
        }
    }
}