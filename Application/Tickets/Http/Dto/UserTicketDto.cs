namespace Application.Tickets.Http.Dto;

public class UserTicketDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Username { get; set; } = default!;
}