using Application.Interfaces;
using Application.Managers;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICategoryManager, CategoryManager>();
        services.AddScoped<ICarManager, CarManager>();
        services.AddScoped<ICustomerManager, CustomerManager>();
        services.AddScoped<IEmployeeManager, EmployeeManager>();
        services.AddScoped<IPaymentManager, PaymentManager>();
        services.AddScoped<IRentalManager, RentalManager>();
        services.AddScoped<IReservationManager, ReservationManager>();
        
        TypeAdapterConfig.GlobalSettings.Default.IgnoreNullValues(true);

        return services;
    }
}