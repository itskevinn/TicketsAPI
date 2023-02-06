using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mapping;

public class TicketDetailConfiguration : IEntityTypeConfiguration<TicketDetail>
{
    public void Configure(EntityTypeBuilder<TicketDetail> builder)
    {
        builder.HasKey(t => t.Id);
        builder.HasMany(t => t.Attachments).WithOne();
        builder.Property(p => p.LastModifiedBy).IsRequired(false);
    }
}