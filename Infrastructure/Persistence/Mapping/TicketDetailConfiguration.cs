
using Domain.Entity.Base;

namespace Infrastructure.Persistence.Mapping;

public class TicketDetail : AuditableEntity<Guid>
{
    public string Message { get; set; } = default!;
    public List<string> AttachmentsUrls { get; set; } = default!;
}