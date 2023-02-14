using Application.Http.Dto;
using AutoMapper;
using Domain.Entity;

namespace Application.Http.Profiles;

public class AttachmentProfile: Profile
{
    public AttachmentProfile()
    {
        CreateMap<Attachment, AttachmentDto>();
    }
}