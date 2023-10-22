using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TicketsGateway.Application.Base;
using TicketsGateway.Application.Security;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;
using TicketsGateway.Application.TicketManagement.Service;

namespace TicketsGateway.Api.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class TicketController : Controller
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet("GetAll")]
    [Authorize(new[] { "Admin", "User" })]
    public async Task<Response<IEnumerable<TicketDto>>> GetAll()
    {
        return await _ticketService.GetAllAsync(HttpContext.Request.Headers["Authorization"]);
    }

    [HttpGet("GetById/{id:guid}")]
    [Authorize(new[] { "Admin", "User" })]
    public async Task<Response<TicketDto>> GetById(Guid id)
    {
        return await _ticketService.GetByIdAsync(id, HttpContext.Request.Headers["Authorization"]);
    }

    [HttpGet("GetByCode/{code:int}")]
    [Authorize(new[] { "Admin", "User" })]
    public async Task<Response<TicketDto>> GetByCode(int code)
    {
        return await _ticketService.GetByCodeAsync(code, HttpContext.Request.Headers["Authorization"]);
    }

    [HttpPost("Create")]
    [Authorize(new[] { "Admin", "User" })]
    public async Task<Response<TicketDto>> Create([FromForm] TicketRequest ticketRequest)
    {
        return await _ticketService.CreateAsync(ticketRequest, HttpContext.Request.Headers["Authorization"]);
    }

    [HttpPut("Update")]
    [Authorize(new[] { "Admin", "User" })]
    public async Task<Response<TicketDto>> Update([FromForm] UpdateTicketRequest ticketRequest)
    {
        return await _ticketService.Update(ticketRequest, HttpContext.Request.Headers["Authorization"]);
    }

    [HttpPatch("UpdateStatus")]
    [Authorize(new[] { "Admin", "User" })]
    public async Task<Response<bool>> UpdateStatus([Required] string newState,
        [Required] int code)
    {
        return await _ticketService.UpdateStatusAsync(newState, code, HttpContext.Request.Headers["Authorization"]);
    }

    [HttpPatch("GetAllAvailableUsersAsync")]
    [Authorize(new[] { "Admin", "User" })]
    public async Task<Response<IEnumerable<UserTicketDto>>> GetAllAvailableUsersAsync()
    {
        return await _ticketService.GetAllAvailableUsersAsync(HttpContext.Request.Headers["Authorization"]);
    }
}