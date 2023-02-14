using Application.Http.Dto;
using Application.Http.Request;
using AutoMapper;
using Domain.Entity;

namespace Application.Http.Profiles;

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