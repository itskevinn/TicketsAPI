using System.ComponentModel.DataAnnotations;
using Application.Base;
using Application.Http.Dto;
using Application.Http.Request;
using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace TicketsWebServices.Controllers;

[Route("/api/v1/[controller]")]
[ApiController]
public class TicketController : Controller
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet("All")]
    public async Task<Response<IEnumerable<TicketDto>>> GetAll()
    {
        return await _ticketService.GetAllAsync();
    }

    [HttpPost("Create")]
    public async Task<Response<TicketDto>> Create(TicketRequest request)
    {
        return await _ticketService.CreateAsync(request);
    }

    [HttpGet("GetById/{id:guid}")]
    public async Task<Response<TicketDto>> GetById(Guid id)
    {
        return await _ticketService.GetByIdAsync(id);
    }

    [HttpGet("GetByCode/{code:int}")]
    public Response<TicketDto> GetById(int code)
    {
        return _ticketService.GetByCodeAsync(code);
    }

    [HttpPut("Update")]
    public Response<TicketDto> Update(UpdateTicketRequest updateTicketRequest)
    {
        return _ticketService.Update(updateTicketRequest);
    }

    [HttpPatch("UpdateStatus")]
    public async Task<Response<bool>> UpdateStatus([Required] int code, [Required] string newStatus)
    {
        return await _ticketService.UpdateStatusAsync(newStatus, code);
    }

    [HttpGet("GetAllAvailableUsers")]
    public Response<IEnumerable<UserTicketDto>> GetAllUsers()
    {
        return _ticketService.GetAllAvailableUsersAsync();
    }
}