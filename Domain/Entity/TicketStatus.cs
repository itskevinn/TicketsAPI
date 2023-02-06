using Domain.Entity.Base;

namespace Domain.Entity;

public class TicketStatus : AuditableEntity<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string BackgroundColor { get; set; } = default!;
    public string Color { get; set; } = default!;
}