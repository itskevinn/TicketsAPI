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
        modelBuilder.HasDefaultSchema(_settings?.SchemaName);
        EntitiesConfigurator.Configure(modelBuilder);
        Seeder.GenerateSeeds(modelBuilder);
    }
}