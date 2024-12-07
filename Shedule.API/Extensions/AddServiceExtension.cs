using Mapster;
using MapsterMapper;
using Shedule.Infrastructure.Services.Implementations;
using Shedule.Infrastructure.Services.Interfaces;
using System.Data;
using System.Reflection;

namespace Shedule.API.Extensions;

public static class AddServiceExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddMapster();
        services.AddRegisterService();
    }
    public static void AddMapster(this IServiceCollection services)
    {
        TypeAdapterConfig config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        Mapper mapperConf = new(config);
        services.AddSingleton<IMapper>(mapperConf);
    }
    public static void AddRegisterService(this IServiceCollection services)
    {
        services.AddScoped<IDbConnectionManager, DbConnectionManager>();
    }
}
