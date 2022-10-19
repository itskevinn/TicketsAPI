using Application.Security.Http.Dto;

namespace Application.Tickets.Http.Dto;

public class TicketDto
{
    public string Code { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Message { get; set; } = default!;
    public string Status { get; set; } = default!;
    public UserDto GeneratedBy { get; set; } = default!;
    public DateTime GeneratedOn { get; set; }
    public DateTime SolvedOn { get; set; }
    public DateTime AllegedSolveDate { get; set; }
    public string Description { get; set; } = default!;
    public IEnumerable<TicketDetailDto> TicketDetails { get; set; } = default!;
}