using Microsoft.AspNetCore.Http;

namespace TicketsGateway.Application.TicketManagement.Http.Request;

public class TicketDetailRequest
{
    public Guid TicketId { get; set; } = Guid.Empty;
    public string? Message { get; set; } = default!;
    public IEnumerable<IFormFile>? Attachments { get; set; } = default!;
}