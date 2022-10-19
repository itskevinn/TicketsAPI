using Application.Tickets.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Tickets.Http.Profiles;

public class TicketDetailProfile : Profile
{
    public TicketDetailProfile()
    {
        CreateMap<TicketDetail, TicketDetailDto>();
    }
}