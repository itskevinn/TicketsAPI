using Application.Http.Profiles;
using AutoMapper;

namespace TicketsWebServices.Utils.Extensions;

public static class AutoMapperExtensions
{
    public static IServiceCollection AddMappings(this IServiceCollection svc)
    {
        var mapperConfig = new MapperConfiguration(m =>
        {
            var profiles = new List<Profile>
            {
               
                new TicketProfile(),
                new TicketDetailProfile(),
                new TicketStatusProfile(),
                new AttachmentProfile()
            };
            m.AddProfiles(profiles);
        });
        var mapper = mapperConfig.CreateMapper();
        svc.AddSingleton(mapper);
        return svc;
    }
}