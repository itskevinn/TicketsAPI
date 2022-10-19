using Application.Security.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Security.Http.Profiles;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<Role, RoleDto>().ReverseMap()
            .ForMember(r => r.Authorities, a
                => a.MapFrom(ar => ar.Authorities));
    }
}