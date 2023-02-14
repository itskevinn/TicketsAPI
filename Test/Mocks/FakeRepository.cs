using System.Data.Common;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Core.Helpers;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.Mocks;

public class FakeRepository
{
    private readonly AppSettings? _appSettings;
    private readonly DbContextOptions<TicketsContext> _options;

    public FakeRepository()
    {
        _appSettings = Helper.GetAppSettings();
        _options = new DbContextOptionsBuilder<TicketsContext>().UseInMemoryDatabase(databaseName: "TicketsMemoryDb")
            .Options;
    }

    public async Task<ITicketRepository> GetInMemoryTicketsRepository()
    {
        if (_appSettings == null) return null!;
        var connection = new Mock<DbConnection>();
        var context = new TicketsContext(_options, _appSettings);
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
        await Populate(context);
        var repo = new TicketRepository(context, connection.Object);
        return repo;
    }

    public async Task<ITicketStatusRepository> GetInMemoryTicketStatusRepository()
    {
        if (_appSettings == null) return null!;
        var context = new TicketsContext(_options, _appSettings);
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
        await Populate(context);
        var repo = new TicketStatusRepository(context);
        return repo;
    }
    

    private static async Task Populate(DbContext context)
    {
        context.Set<Ticket>().AddRange(
            new Ticket
            {
                Id = new Guid("a4c7072e-dd10-4d5b-8dfa-4dfa0a5a4e00"),
                Code = 82,
                Title = "No recupera los detalles por código",
                AssignedTo = "User",
                GeneratedBy = "Admin",
                GeneratedOn = DateTime.Parse("2023-02-05"),
                SolvedOn = DateTime.Parse("2023-02-06"),
                AllegedSolveDate = DateTime.Parse("2023-02-10"),
                Description = "",
                Status = true,
                CreatedBy = "yopitip",
                CreatedOn = new DateTime()
            }, new Ticket
            {
                Id = new Guid("a4c7072e-dd10-4d5b-8dfa-4dfa0a5a4e01"),
                Code = 83,
                Title = "No recupera los archivos",
                AssignedTo = "User",
                GeneratedBy = "Admin",
                GeneratedOn = DateTime.Parse("2023-02-06"),
                SolvedOn = DateTime.Parse("0001-01-01"),
                AllegedSolveDate = DateTime.Parse("2023-02-10"),
                Description = "",
                Status = true,
                CreatedBy = "yopitip",
                CreatedOn = new DateTime()
            });
        context.Set<TicketStatus>().AddRange(
            new TicketStatus
            {
                Id = new Guid("a4c7072e-dd10-4d5b-8dfa-4dfa0a5a4e00"),
                Color = "White",
                Name = "Resuelto",
                BackgroundColor = "Black",
                Description = "",
                Status = true,
                CreatedBy = "yopitip",
                CreatedOn = new DateTime()
            });
        context.Set<TicketDetail>().AddRange(
            new TicketDetail
            {
                Attachments = new List<Attachment>(),
                Id = new Guid("a4c7072e-dd10-4d5b-8dfa-4dfa0a5a4111"),
                Message = "chi",
                TicketId = new Guid("a4c7072e-dd10-4d5b-8dfa-4dfa0a5a4e00"),
                TicketCode = 82,
                Status = true,
                CreatedBy = "yopitip",
                CreatedOn = new DateTime()
            });
        await context.SaveChangesAsync();
    }
}