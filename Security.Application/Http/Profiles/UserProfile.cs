using AutoMapper;
using Security.Application.Http.Dto;
using Security.Application.Http.Request;
using Security.Domain.Entity;

namespace Security.Application.Http.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRequest, User>().ReverseMap();
        CreateMap<UserUpdateRequest, User>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap()
            .ForMember(r => r.Roles, u
                => u.MapFrom(ur => ur.Roles));
        CreateMap<UserDto, Security.Infrastructure.Security.Models.UserDto>()
            .ForMember(r => r.Roles,
                u => u.MapFrom(ur => ur.Roles));
    }
}