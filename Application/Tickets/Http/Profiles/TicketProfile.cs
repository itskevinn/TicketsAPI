using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using AutoMapper;
using Domain.Entity;

namespace Application.Tickets.Http.Profiles;

public class TicketProfile : Profile
{
    public TicketProfile()
    {
        CreateMap<Ticket, TicketDto>()
            .ForMember(t => t.TicketStatus, 
                t => t.MapFrom(ticket => ticket.TicketStatus))
            //Ignore AssignedTo property for being mapped because it must be assigned from the service
            .ForMember(t => t.AssignedTo, opt => opt.Ignore());
        CreateMap<TicketRequest, Ticket>();
        CreateMap<UpdateTicketRequest, Ticket>();
    }
}