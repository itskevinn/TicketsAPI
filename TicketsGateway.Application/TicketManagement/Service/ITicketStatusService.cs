using Application.Base;
using Application.Http.Dto;
using Infrastructure.Core.Interface;

namespace Application.Service;

public interface ITicketStatusService : ITransientService
{
    /// <summary>
    /// Method used to retrieve all the status of the tickets
    /// </summary>
    /// <returns>An enumerable of <see cref="TicketStatusDto"/></returns>
    public Task<Response<IEnumerable<TicketStatusDto>>> GetAll();
}