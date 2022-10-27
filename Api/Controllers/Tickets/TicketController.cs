using System.ComponentModel.DataAnnotations;
using Application.Base;
using Application.Security;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using Application.Tickets.Service;
using Microsoft.AspNetCore.Mvc;

namespace TicketsWebServices.Controllers.Tickets;

[Route("/api/v1/[controller]")]
[ApiController]
public class TicketController : Controller
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpGet("All")]
    public async Task<Response<IEnumerable<TicketDto>>> GetAll()
    {
        return await _ticketService.GetAllAsync();
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpPost("Create")]
    public async Task<Response<TicketDto>> Create(TicketRequest request)
    {
        return await _ticketService.CreateAsync(request);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpGet("GetById/{id:guid}")]
    public async Task<Response<TicketDto>> GetById(Guid id)
    {
        return await _ticketService.GetByIdAsync(id);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpGet("GetByCode/{code:int}")]
    public Response<TicketDto> GetById(int code)
    {
        return _ticketService.GetByCodeAsync(code);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpPut("Update")]
    public Response<TicketDto> Update(UpdateTicketRequest code)
    {
        return _ticketService.Update(code);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpPatch("UpdateStatus")]
    public async Task<Response<bool>> UpdateStatus([Required] string newState, [Required] int code)
    {
        return await _ticketService.UpdateStatusAsync(newState, code);
    }
}