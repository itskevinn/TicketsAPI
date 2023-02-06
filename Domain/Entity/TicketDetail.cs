
using Domain.Entity.Base;

namespace Domain.Entity;

public class TicketDetail : AuditableEntity<Guid>
{
    public Guid TicketId { get; set; }  = Guid.Empty;
    public string Message { get; set; } = default!;
    public int TicketCode { get; set; }
    public IEnumerable<Attachment> Attachments { get; set; } = default!;
}