using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mapping;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.Property(t => t.Code).IsRequired();
        builder.Property(t => t.Title).HasMaxLength(255);
        builder.Property(t => t.Status).IsRequired();
        builder.Property(t => t.GeneratedOn).IsRequired();
        builder.Property(t => t.AllegedSolveDate).IsRequired();
        builder.Property(t => t.Description).IsRequired();
        
        builder.Ignore(t => t.GeneratedBy);
    }
}