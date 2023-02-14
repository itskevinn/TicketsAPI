using Application.Http.Profiles;
using Application.Service.Implementation;
using AutoMapper;
using Infrastructure.Persistence.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Moq;
using Test.Mocks;

namespace Test.Application.Ticket.Services;

public class TicketServiceTests
{
    private readonly MapperConfiguration _mapperConfig = new(cfg => { cfg.AddProfile(new TicketProfile()); });
    private readonly IMapper _ticketMapper;

    public TicketServiceTests()
    {
        _ticketMapper = _mapperConfig.CreateMapper();
    }

    [Fact]
    public async Task TicketService_GetAll_ReturnsTickets()
    {
        //Arrange
        var loggerMock = new Mock<ILogger<TicketService>>();
        var connectionFactoryMock = new Mock<IConnectionFactory>();

        var fakeRepository = new FakeRepository();
        var httpContextAccessorMock = new Mock<IHttpContextAccessor>();

        var ticketService = new TicketService(_ticketMapper, loggerMock.Object, connectionFactoryMock.Object,
            httpContextAccessorMock.Object,
            await fakeRepository.GetInMemoryTicketsRepository(),
            await fakeRepository.GetInMemoryTicketStatusRepository());

        //Act
        var response = await ticketService.GetAllAsync();

        //Assert
        var tickets = response.Data.AsQueryable();
        Assert.NotEmpty(tickets);
        Assert.Equal(2, tickets.Count());
    }

    [Fact]
    public async Task TicketService_GetById_ReturnsTicket()
    {
        //Arrange
        var ticketId = new Guid("a4c7072e-dd10-4d5b-8dfa-4dfa0a5a4e00");
        var loggerMock = new Mock<ILogger<TicketService>>();
        var connectionFactoryMock = new Mock<IConnectionFactory>();

        var fakeRepository = new FakeRepository();
        var httpContextAccessorMock = new Mock<IHttpContextAccessor>();

        var ticketService = new TicketService(_ticketMapper, loggerMock.Object, connectionFactoryMock.Object,
            httpContextAccessorMock.Object,
            await fakeRepository.GetInMemoryTicketsRepository(),
            await fakeRepository.GetInMemoryTicketStatusRepository());
        //Act
        var response = await ticketService.GetByIdAsync(ticketId);
        //Assert
        var ticket = response.Data;
        Assert.NotNull(ticket);
    }

    [Fact]
    public async Task TicketService_GetByIdNotFount_ThrowsTicketNotFoundException()
    {
        //Arrange
        var ticketId = new Guid("a4c7072e-dd10-4d5b-8dfa-4dfa0a5a4e4e");
        var loggerMock = new Mock<ILogger<TicketService>>();
        var connectionFactoryMock = new Mock<IConnectionFactory>();

        var fakeRepository = new FakeRepository();
        var httpContextAccessorMock = new Mock<IHttpContextAccessor>();

        var ticketService = new TicketService(_ticketMapper, loggerMock.Object, connectionFactoryMock.Object,
            httpContextAccessorMock.Object,
            await fakeRepository.GetInMemoryTicketsRepository(),
            await fakeRepository.GetInMemoryTicketStatusRepository());
        //Act
        var response = await ticketService.GetByIdAsync(ticketId);
        //Assert
        Assert.Null(response.Data);
    }
}