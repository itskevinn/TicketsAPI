
using Domain.Entity.Base;

namespace Domain.Entity;

public class TicketDetail : AuditableEntity<Guid>
{
    public string Message { get; set; } = default!;
    public IEnumerable<Attachment> Attachments { get; set; } = default!;
}