using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using AutoMapper;
using Domain.Entity;

namespace Application.Tickets.Http.Profiles;

public class TicketDetailProfile : Profile
{
    public TicketDetailProfile()
    {
        CreateMap<TicketDetail, TicketDetailDto>();
        CreateMap<TicketDetailRequest, TicketDetail>()
            .ForSourceMember(t => t.Attachments, opt => opt.DoNotValidate())
            .ForMember(t => t.Attachments, opt => opt.Ignore());
    }
}