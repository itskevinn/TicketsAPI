using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Mapping;

public class TicketDetailConfiguration : IEntityTypeConfiguration<TicketDetail>
{
    public void Configure(EntityTypeBuilder<TicketDetail> builder)
    {
        builder.ToTable("TicketDetail");
        builder.HasKey(t => t.Id);
    }
}