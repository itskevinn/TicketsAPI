using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Interface;
using TicketsGateway.Application.Exceptions;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;

namespace TicketsGateway.Application.TicketManagement.Service;

public interface ITicketService : ITransientService
{
    /// <summary>
    /// Method that retrieves all tickets registered in the database
    /// </summary>
    /// <returns cref="TicketDto">An enumerable of the tickets found in database <see cref="Response{T}"/> <see cref="IEnumerable{T}"/> <see cref="TicketDto"/></returns>
    Task<Response<IEnumerable<TicketDto>>> GetAllAsync(string token);

    /// <summary>
    /// Method that finds the ticket associated with the specified code in the database
    /// </summary>
    /// <param name="code">Id of the ticket to search for</param>
    /// <param name="token">Auth token</param>
    /// <returns>dto of the ticket found in database wrapped in response <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    Task<Response<TicketDto>> GetByCodeAsync(int code, string token);

    /// <summary>
    /// Method that finds the ticket associated with the specified code in the database
    /// </summary>
    /// <param name="id">Id of the ticket to search for</param>
    /// <param name="token">Auth token</param>
    /// <returns cref="TicketDto">dto of the ticket found in database <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    Task<Response<TicketDto>> GetByIdAsync(Guid id, string token);

    /// <summary>
    /// Method used to validate and call db to save the ticket
    /// </summary>
    /// <param cref="TicketRequest" name="request">Ticket request sent from client</param>
    /// <param name="token">Auth token</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    Task<Response<TicketDto>> CreateAsync(TicketRequest request, string token);

    /// <summary>
    /// Method used to updating the ticket
    /// </summary>
    /// <param cref="UpdateTicketRequest" name="request">Ticket request sent from client</param>
    /// <param name="token">Auth token</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    Task<Response<TicketDto>> Update(UpdateTicketRequest request, string token);

    /// <summary>
    /// Method used to updating the ticket
    /// </summary>
    /// 
    /// <param name="code">Id of the ticket to update status</param>
    /// <param name="newState">New status for the ticket</param>
    /// <param name="token">Auth token</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    Task<Response<bool>> UpdateStatusAsync(string newState, int code, string token);

    /// <summary>
    /// Method used to get all users available to assign tickets
    /// </summary>
    Task<Response<IEnumerable<UserTicketDto>>> GetAllAvailableUsersAsync(string token);
}