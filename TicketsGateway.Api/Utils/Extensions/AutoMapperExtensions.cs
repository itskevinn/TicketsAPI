using AutoMapper;
using TicketsGateway.Application.Security.Http.Profiles;

namespace TicketsGateway.Api.Utils.Extensions;

public static class AutoMapperExtensions
{
    public static IServiceCollection AddMappings(this IServiceCollection svc)
    {
        var mapperConfig = new MapperConfiguration(m =>
        {
            var profiles = new List<Profile>
            {
                new UserProfile(),
            };
            m.AddProfiles(profiles);
        });
        var mapper = mapperConfig.CreateMapper();
        svc.AddSingleton(mapper);
        return svc;
    }
}