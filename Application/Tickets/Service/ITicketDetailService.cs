using Application.Base;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using Infrastructure.Core.Interface;

namespace Application.Tickets.Service;

public interface ITicketDetailService : ITransientService
{
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode);
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId);
    Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request);
    Task<Response<TicketDetailDto>> UpdateAsync(UpdateTicketDetailRequest request);
    Task<Response<bool>> Delete(Guid ticketDetailId);

}