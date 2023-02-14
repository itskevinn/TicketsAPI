namespace Application.Http.Request;

public class UpdateTicketRequest : TicketRequest
{
    public Guid Id { get; set; }
    public int Code { get; set; }
    public string LastModifiedBy { get; set; } = default!;
}