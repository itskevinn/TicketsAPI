using Domain.Entity.Base;

namespace Domain.Entity;

public class Ticket : AuditableEntity<Guid>
{
    public string Code { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Message { get; set; } = default!;
    public string Status { get; set; } = default!;
    public User GeneratedBy { get; set; } = default!;
    public DateTime GeneratedOn { get; set; }
    public DateTime SolvedOn { get; set; }
    public DateTime AllegedSolveDate { get; set; }
    public string Description { get; set; } = default!;
}