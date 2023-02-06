using Application.Base;
using Application.Security;
using Application.Tickets.Http.Dto;
using Application.Tickets.Service;
using Microsoft.AspNetCore.Mvc;

namespace TicketsWebServices.Controllers.Tickets;

[Route("/api/v1/[controller]")]
[ApiController]
public class TicketStatusController : Controller
{
    private readonly ITicketStatusService _ticketStatusService;

    public TicketStatusController(ITicketStatusService ticketStatusService)
    {
        _ticketStatusService = ticketStatusService;
    }

    [Authorize(new[] { "Admin" })]
    [HttpGet("GetAll")]
    public async Task<Response<IEnumerable<TicketStatusDto>>> GetAll()
    {
        return await _ticketStatusService.GetAll();
    }
}