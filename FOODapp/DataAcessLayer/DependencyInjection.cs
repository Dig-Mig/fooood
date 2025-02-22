using DataAcessLayer.Data;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcessLayer;

public static class DependencyInjection
{

    public static IServiceCollection AddDataAcessLayer(this IServiceCollection services)
    {
        services.AddDbContext<FOODContext>();
        
        return services;
    }
    
}