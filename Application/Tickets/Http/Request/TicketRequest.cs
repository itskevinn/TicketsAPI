using System.ComponentModel.DataAnnotations;

namespace Application.Tickets.Http.Request;

public class TicketRequest
{
    [Required(ErrorMessage = "You must provide a title")]
    public string Title { get; set; } = default!;

    [Required(ErrorMessage = "You must provide a status")]
    public Guid StatusId { get; set; } = Guid.Empty;

    public string AssignedTo { get; set; } = default!;
    public DateTime? SolvedOn { get; set; } = default!;
    public DateTime? AllegedSolveDate { get; set; } = default!;
    public string? SolvedBy { get; set; } = default!;
    public string? Description { get; set; } = default!;
    public IEnumerable<TicketDetailRequest>? TicketDetails { get; set; } = default!;
}