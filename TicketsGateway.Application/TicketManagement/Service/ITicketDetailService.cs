using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Interface;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;

namespace TicketsGateway.Application.TicketManagement.Service;

public interface ITicketDetailService : ITransientService
{
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode, string token);
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId, string token);
    Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request, string token);
    Task<Response<TicketDetailDto>> UpdateAsync(UpdateTicketDetailRequest request, string token);
    Task<Response<bool>> Delete(Guid ticketDetailId, string token);
}