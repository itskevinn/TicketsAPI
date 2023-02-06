using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;
using Infrastructure.Persistence.UnitOfWork;

namespace Infrastructure.Persistence.Repositories;

public class TicketStatusRepository : GenericRepository<TicketStatus>, ITicketStatusRepository
{
    public TicketStatusRepository(TicketsContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }
    
}