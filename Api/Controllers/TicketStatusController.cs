using Application.Base;
using Application.Http.Dto;
using Application.Security;
using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace TicketsWebServices.Controllers;

[Route("/api/v1/[controller]")]
[ApiController]
public class TicketStatusController : Controller
{
    private readonly ITicketStatusService _ticketStatusService;

    public TicketStatusController(ITicketStatusService ticketStatusService)
    {
        _ticketStatusService = ticketStatusService;
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpGet("GetAll")]
    public async Task<Response<IEnumerable<TicketStatusDto>>> GetAll()
    {
        return await _ticketStatusService.GetAll();
    }
}