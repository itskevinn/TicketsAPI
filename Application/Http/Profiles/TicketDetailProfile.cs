using Application.Http.Dto;
using Application.Http.Request;
using AutoMapper;
using Domain.Entity;

namespace Application.Http.Profiles;

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