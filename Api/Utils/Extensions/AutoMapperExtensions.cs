using Application.Security.Http.Profiles;
using Application.Tickets.Http.Profiles;
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
                new MenuItemProfile(),
                new RoleProfile(),
                new UserProfile(),
                new TicketProfile(),
                new TicketDetailProfile()
            };
            m.AddProfiles(profiles);
        });
        var mapper = mapperConfig.CreateMapper();
        svc.AddSingleton(mapper);
        return svc;
    }
}