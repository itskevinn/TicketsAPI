﻿namespace TicketsGateway.Application.Security.Http.Request;

public class UserUpdateRequest : UserRequest
{
    public Guid Id { get; set; }
    public string LastModifiedBy { get; set; } = default!;
}