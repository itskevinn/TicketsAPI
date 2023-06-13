﻿namespace TicketsGateway.Application.Security.Http.Dto;

public class AuthenticateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Username { get; set; } = default!;
    public string Token { get; set; } = default!;
    public IEnumerable<RoleDto> Roles { get; set; } = default!;
}