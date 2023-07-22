namespace TicketsGateway.Application.TicketManagement.Http.Request;

public class UpdateTicketDetailRequest : TicketDetailRequest
{
    public Guid Id { get; set; }
}