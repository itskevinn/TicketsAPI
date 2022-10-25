using System.ComponentModel.DataAnnotations;

namespace Application.Tickets.Http.Request;

public class TicketRequest
{
    [Required(ErrorMessage = "You must provide a title")]
    public string Title { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string GeneratedBy { get; set; } = default!;
    public DateTime GeneratedOn { get; set; }
    public DateTime SolvedOn { get; set; }
    public DateTime AllegedSolveDate { get; set; }
    public string? Description { get; set; } = default!;
    public IEnumerable<TicketDetailRequest>? TicketDetails { get; set; } = default!;
}