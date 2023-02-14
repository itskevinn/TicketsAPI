using Infrastructure.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Configuration;

public static class EntitiesConfigurator
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TicketConfiguration());
        modelBuilder.ApplyConfiguration(new TicketStatusConfiguration());
        modelBuilder.ApplyConfiguration(new TicketDetailConfiguration());
        modelBuilder.ApplyConfiguration(new AttachmentConfiguration());
    }
}