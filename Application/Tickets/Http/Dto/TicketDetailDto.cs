namespace Application.Tickets.Http.Dto;

public class TicketDetailDto
{
    public string Message { get; set; } = default!;
    public IEnumerable<AttachmentDto> Attachments { get; set; } = default!;
}