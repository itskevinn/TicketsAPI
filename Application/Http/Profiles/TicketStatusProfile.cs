using Application.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Http.Profiles;

public class TicketStatusProfile : Profile
{
    public TicketStatusProfile()
    {
        CreateMap<TicketStatus, TicketStatusDto>().ReverseMap();
    }
}