using Application.Base;
using Application.Tickets.Http.Dto;
using Application.Tickets.Service;
using Microsoft.AspNetCore.Authorization;
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

    [Authorize("Jwt")]
    [HttpGet("All")]
    public async Task<Response<IEnumerable<TicketDto>>> GetAll()
    {
        return await _ticketService.GetAllAsync();
    }
}