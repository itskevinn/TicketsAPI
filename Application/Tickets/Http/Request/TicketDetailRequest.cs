using Microsoft.AspNetCore.Http;

namespace Application.Tickets.Http.Request;

public class TicketDetailRequest
{
    public string Message { get; set; } = default!;
    public IEnumerable<IFormFile> Attachments { get; set; } = default!;
}