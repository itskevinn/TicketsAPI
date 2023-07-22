using Application.Base;
using Application.Http.Dto;
using Application.Http.Request;
using Application.Security;
using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace TicketsWebServices.Controllers;

[Route("/api/v1/[controller]")]
[ApiController]
public class TicketDetailController : Controller
{
    private readonly ITicketDetailService _ticketDetailService;

    public TicketDetailController(ITicketDetailService ticketDetailService)
    {
        _ticketDetailService = ticketDetailService;
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpGet("All/{ticketCode:int}")]
    public async Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode)
    {
        return await _ticketDetailService.GetAllByTicketCode(ticketCode);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpGet("All/{ticketId:guid}")]
    public async Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId)
    {
        return await _ticketDetailService.GetAllByTicketId(ticketId);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpPost("Create")]
    public async Task<Response<TicketDetailDto>> Create([FromForm] TicketDetailRequest request)
    {
        return await _ticketDetailService.CreateAsync(request);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpPut("Update")]
    public async Task<Response<TicketDetailDto>> Update([FromForm] UpdateTicketDetailRequest updateTicketDetailRequest)
    {
        return await _ticketDetailService.UpdateAsync(updateTicketDetailRequest);
    }

    [Authorize(new[] { "Admin", "User" })]
    [HttpDelete("Delete")]
    public async Task<Response<bool>> Delete(Guid ticketDetailId)
    {
        return await _ticketDetailService.Delete(ticketDetailId);
    }
}