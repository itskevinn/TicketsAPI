namespace Application.Tickets.Http.Request;

public class UpdateTicketDetailRequest : TicketDetailRequest
{
    public Guid Id { get; set; }
}