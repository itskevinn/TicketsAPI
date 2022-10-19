using Application.Tickets.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Tickets.Http.Profiles;

public class TicketProfile : Profile
{
    public TicketProfile()
    {
        CreateMap<Ticket, TicketDto>();
    }
}