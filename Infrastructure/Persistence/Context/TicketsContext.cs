using Domain.Entity;
using Infrastructure.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Context;

public class TicketsContext : DbContext
{
    public DbSet<User> Users { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}