using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Interface;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;

namespace TicketsGateway.Application.TicketManagement.Service;

public interface ITicketDetailService : ITransientService
{
    /// <summary>
    /// Method that retrieves all details of the ticket by a given ticketCode
    /// <param name="token">Auth token</param>
    /// <param name="ticketCode">Given ticket code</param>
    /// </summary>
    /// <returns cref="TicketDetailDto">An enumerable of the tickets found in database <see cref="Response{T}"/> <see cref="IEnumerable{T}"/> <see cref="TicketDetailDto"/></returns>
    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode, string token);

    Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId, string token);
    Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request, string token);
    Task<Response<TicketDetailDto>> UpdateAsync(UpdateTicketDetailRequest request, string token);
    Task<Response<bool>> Delete(Guid ticketDetailId, string token);
}