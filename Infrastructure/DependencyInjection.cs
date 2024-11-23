using Core.Domain.Interfaces;
using Infrastructure.Adapters.Repositories;
using Infrastrucute.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CarRentalDbContext>(options =>
            options.UseSqlServer(configuration["CarRental:ConnectionString"]));

        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IPaymentRepository, PaymentRepository>();
        services.AddScoped<IRentalRepository, RentalRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}