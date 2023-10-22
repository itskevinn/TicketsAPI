using RestEase;
using TicketsGateway.Application.Exceptions;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;

namespace TicketsGateway.Application.TicketManagement.RestEaseClients;

public interface ITicketRestEaseClient
{
    /// <summary>
    /// Method that retrieves all tickets registered in the database
    /// </summary>
    /// <returns cref="TicketDto">An enumerable of the tickets found in database <see cref="Response{T}"/> <see cref="IEnumerable{T}"/> <see cref="TicketDto"/></returns>
    [Get("api/v1/Ticket/All")]
    Task<TicketsGateway.Application.Base.Response<IEnumerable<TicketDto>>> GetAllAsync(
        [Header("Authorization")] string token);

    /// <summary>
    /// Method that finds the ticket associated with the specified code in the database
    /// </summary>
    /// <param name="code">Id of the ticket to search for</param>
    /// <param name="token">Auth token</param>
    /// <returns>dto of the ticket found in database wrapped in response <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    [Get("api/v1/Ticket/GetByCode/{code}")]
    Task<TicketsGateway.Application.Base.Response<TicketDto>> GetByCodeAsync([Path] int code,
        [Header("Authorization")] string token);

    /// <summary>
    /// Method that finds the ticket associated with the specified code in the database
    /// </summary>
    /// <param name="id">Id of the ticket to search for</param>
    /// <param name="token">Auth token</param>
    /// <returns cref="TicketDto">dto of the ticket found in database <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    [Get("api/v1/Ticket/GetById/{id}")]
    Task<TicketsGateway.Application.Base.Response<TicketDto>> GetByIdAsync([Path] Guid id,
        [Header("Authorization")] string token);

    /// <summary>
    /// Method used to validate and call db to save the ticket
    /// </summary>
    /// <param name="token">Auth token</param>
    /// <param cref="TicketRequest" name="request">Ticket request sent from client</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    [Post("api/v1/Ticket/Create")]
    Task<TicketsGateway.Application.Base.Response<TicketDto>> CreateAsync([Body] TicketRequest request,
        [Header("Authorization")] string token);

    /// <summary>
    /// Method used to updating the ticket
    /// </summary>
    /// <param cref="UpdateTicketRequest" name="request">Ticket request sent from client</param>
    /// <param name="token">Auth token</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    [Put("api/v1/Ticket/Update")]
    Task<TicketsGateway.Application.Base.Response<TicketDto>> Update([Body] UpdateTicketRequest request,
        [Header("Authorization")] string token);

    /// <summary>
    /// Method used to updating the ticket
    /// </summary>
    /// 
    /// <param name="code">Id of the ticket to update status</param>
    /// <param name="newState">New status for the ticket</param>
    /// <param name="token">Auth token</param>
    /// <returns> Saved ticket <see cref="Response{T}"/> <see cref="TicketDto"/></returns>
    /// <exception cref="UserNotFoundException"></exception>
    [Patch("api/v1/Ticket/UpdateStatus?code={code}&newState={newState}")]
    Task<TicketsGateway.Application.Base.Response<bool>> UpdateStatusAsync([Path] string newState, [Path] int code,
        [Header("Authorization")] string token);

    /// <summary>
    /// Method used to get all users available to assign tickets
    /// <param name="token">Auth token</param>
    /// </summary>
    [Get("api/v1/Ticket/GetAllAvailableUsers")]
    Task<TicketsGateway.Application.Base.Response<IEnumerable<UserTicketDto>>> GetAllAvailableUsersAsync(
        [Header("Authorization")] string token);
}