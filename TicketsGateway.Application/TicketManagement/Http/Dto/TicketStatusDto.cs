namespace TicketsGateway.Application.TicketManagement.Http.Dto;

public class TicketStatusDto
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string BackgroundColor { get; set; } = default!;
    public string Color { get; set; } = default!;
    public Guid Id { get; set; } = Guid.Empty;
}