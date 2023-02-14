namespace Application.Tickets.Http.Dto;

public class TicketDto
{
    public Guid Id { get; set; } = Guid.Empty;
    public int Code { get; set; }
    public string Title { get; set; } = default!;
    public UserTicketDto AssignedTo { get; set; } = default!;
    public string GeneratedBy { get; set; } = default!;
    public DateTime GeneratedOn { get; set; }
    public DateTime SolvedOn { get; set; }
    public DateTime AllegedSolveDate { get; set; }
    public string Description { get; set; } = default!;
    public TicketStatusDto TicketStatus { get; set; } = default!;
    public IEnumerable<TicketDetailDto> TicketDetails { get; set; } = default!;
}