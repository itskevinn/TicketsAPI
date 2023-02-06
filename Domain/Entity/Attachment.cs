using Domain.Entity.Base;

namespace Domain.Entity;

public class Attachment : AuditableEntity<Guid>
{
    public string Url { get; set; } = default!;
    public Guid TicketDetailId { get; set; } = Guid.Empty;
}