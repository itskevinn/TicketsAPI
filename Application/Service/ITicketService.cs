using Application.Base;
using Application.Exceptions;
using Application.Http.Dto;
using Application.Http.Request;
using Infrastructure.Core.Interface;
using Infrastructure.Persistence.Exceptions;

namespace Application.Service;

public interface ITicketService : ITransientService
{
    /// <summary>
    /// Method that retrieves all tickets registered in the database
    /// </summary>
    /// <returns cref="TicketDto">An enumerable of the tickets found in database <see cref="Response{T}"/> <see cref="IEnumerable{T}"/> <see cref="TicketDto"/></returns>
    Task<Response<IEnumerable<TicketDto>>> GetAllAsync();

    /// <summary>
    /// Method that finds the ticket associated with the specified code in the database
    /// </summary>
    /// <param name="code">Id of the ticket to search for</param>
    /// <returns>dto of the ticket found in database wrapped in response <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    Response<TicketDto> GetByCodeAsync(int code);

    /// <summary>
    /// Method that finds the ticket associated with the specified code in the database
    /// </summary>
    /// <param name="id">Id of the ticket to search for</param>
    /// <returns cref="TicketDto">dto of the ticket found in database <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    Task<Response<TicketDto>> GetByIdAsync(Guid id);

    /// <summary>
    /// Method used to validate and call db to save the ticket
    /// </summary>
    /// <param cref="TicketRequest" name="request">Ticket request sent from client</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="DatabaseUnavailableException"></exception>
    /// <exception cref="UserNotFoundException"></exception>
    Task<Response<TicketDto>> CreateAsync(TicketRequest request);

    /// <summary>
    /// Method used to updating the ticket
    /// </summary>
    /// <param cref="UpdateTicketRequest" name="request">Ticket request sent from client</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    Response<TicketDto> Update(UpdateTicketRequest request);

    /// <summary>
    /// Method used to updating the ticket
    /// </summary>
    /// 
    /// <param name="code">Id of the ticket to update status</param>
    /// <param name="newState">New status for the ticket</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    Task<Response<bool>> UpdateStatusAsync(string newState, int code);
}