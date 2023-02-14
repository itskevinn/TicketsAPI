using Application.Base;
using Application.Http.Dto;
using Application.Http.Request;
using Infrastructure.Core.Interface;

namespace Application.Service;

public interface ITicketDetailService : ITransientService
{
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode);
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId);
    Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request);
    Task<Response<TicketDetailDto>> UpdateAsync(UpdateTicketDetailRequest request);
    Task<Response<bool>> Delete(Guid ticketDetailId);

}