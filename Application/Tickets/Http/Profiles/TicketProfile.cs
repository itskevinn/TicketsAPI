using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using AutoMapper;
using Domain.Entity;

namespace Application.Tickets.Http.Profiles;

public class TicketProfile : Profile
{
    public TicketProfile()
    {
        CreateMap<Ticket, TicketDto>();
        CreateMap<TicketRequest, Ticket>();
    }
}