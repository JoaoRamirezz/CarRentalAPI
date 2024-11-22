using Application.Interfaces;
using Application.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICategoryManager, CategoryManager>();
        
        return services;
    }
}