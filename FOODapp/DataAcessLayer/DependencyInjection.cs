using DataAcessLayer.Data;
using DataAcessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcessLayer;

public static class DependencyInjection
{

    public static IServiceCollection AddDataAcessLayer(this IServiceCollection services)
    {
        services.AddDbContext<FOODContext>();
        services.AddScoped<IngredientsRepository>();
        return services;
    }
    
}