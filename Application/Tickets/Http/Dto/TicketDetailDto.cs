using Microsoft.AspNetCore.Http;

namespace Application.Tickets.Http.Dto;

public class TicketDetailDto
{
    public string Message { get; set; } = default!;
    public IEnumerable<IFormFile> AttachmentsUrls { get; set; } = default!;
}