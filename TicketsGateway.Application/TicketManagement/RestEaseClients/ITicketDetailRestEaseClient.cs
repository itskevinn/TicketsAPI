using Microsoft.AspNetCore.Mvc;
using RestEase;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;

namespace TicketsGateway.Application.TicketManagement.RestEaseClients;

public interface ITicketDetailRestEaseClient
{
    [Get("/FindById/{id}")]
    public Task<Base.Response<UserDto>> GetById();

    [HttpGet("api/v1/Ticket/All/{ticketCode:int}")]
    Task<Base.Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode([Path] int ticketCode,
        [Header("Authorization")] string authorization);

    [HttpGet("api/v1/Ticket/All/{ticketId:guid}")]
    public Task<Base.Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId);

    [HttpPost("api/v1/Ticket/Create")]
    public Task<Base.Response<TicketDetailDto>> Create([FromForm] TicketDetailRequest request);

    [HttpPut("api/v1/Ticket/Update")]
    public Task<Base.Response<TicketDetailDto>> Update(
        [FromForm] UpdateTicketDetailRequest updateTicketDetailRequest);

    [HttpDelete("api/v1/Ticket/UpdateStatus")]
    public Task<Base.Response<bool>> Delete(Guid ticketDetailId);
}