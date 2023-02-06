using Application.Tickets.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Tickets.Http.Profiles;

public class AttachmentProfile: Profile
{
    public AttachmentProfile()
    {
        CreateMap<Attachment, AttachmentDto>();
    }
}