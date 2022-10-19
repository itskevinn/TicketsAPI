using Application.Security.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Security.Http.Profiles;

public class MenuItemProfile : Profile
{
    public MenuItemProfile()
    {
        CreateMap<MenuItem, MenuItemDto>().ReverseMap();
    }
}