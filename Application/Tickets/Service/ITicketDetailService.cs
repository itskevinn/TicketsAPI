using Application.Base;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using Infrastructure.Core.Interface;

namespace Application.Tickets.Service;

public interface ITicketDetailService : ITransientService
{
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode);
    Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request);
    void Update(UpdateTicketDetailRequest request);
    Task<Response<TicketDetailDto>> Delete(TicketDetailRequest request);
}