using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mapping;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Code).IsRequired();
        builder.Property(t => t.Title).HasMaxLength(255);
        builder.Property(t => t.Status).IsRequired();
        builder.Property(t => t.Description).IsRequired(false);
        builder.Property(t => t.LastModifiedBy).IsRequired(false);
    }
}