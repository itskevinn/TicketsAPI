using Microsoft.AspNetCore.Mvc;
using RestEase;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;

namespace TicketsGateway.Application.TicketManagement.RestEaseClients;

public interface ITicketDetailRestEaseClient
{
    [Get("/FindById/{id}")]
    Task<Base.Response<UserDto>> GetById();

    [HttpGet("api/v1/Ticket/All/{ticketCode:int}")]
    Task<Base.Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode([Path] int ticketCode,
        [Header("Authorization")] string authorization);

    [HttpGet("api/v1/Ticket/All/{ticketId:guid}")]
    Task<Base.Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId([Path] Guid ticketId,
        [Header("Authorization")] string authorization);

    [HttpPost("api/v1/Ticket/Create")]
    Task<Base.Response<TicketDetailDto>> Create([Body] TicketDetailRequest request,
        [Header("Authorization")] string authorization);

    [HttpPut("api/v1/Ticket/Update")]
    Task<Base.Response<TicketDetailDto>> Update(
        [Body] UpdateTicketDetailRequest updateTicketDetailRequest, [Header("Authorization")] string authorization);

    [HttpDelete("api/v1/Ticket/UpdateStatus")]
    public Task<Base.Response<bool>> Delete([Path] Guid ticketDetailId, [Header("Authorization")] string authorization);
}