using Application.Tickets.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Tickets.Http.Profiles;

public class TicketStatusProfile : Profile
{
    public TicketStatusProfile()
    {
        CreateMap<TicketStatus, TicketStatusDto>().ReverseMap();
    }
}