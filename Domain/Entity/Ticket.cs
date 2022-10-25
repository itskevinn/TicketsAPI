using Domain.Entity.Base;

namespace Domain.Entity;

public class Ticket : AuditableEntity<Guid>
{
    public int Code { get; set; }
    public string Title { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string GeneratedBy { get; set; } = default!;
    public DateTime GeneratedOn { get; set; }
    public DateTime SolvedOn { get; set; }
    public DateTime AllegedSolveDate { get; set; }
    public string Description { get; set; } = default!;
}