﻿namespace Application.Tickets.Http.Request;

public class UpdateTicketRequest : TicketRequest
{
    public Guid Id { get; set; }
    public string UpdatedBy { get; set; } = default!;
}