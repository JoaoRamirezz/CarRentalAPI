using Core.Domain.Entities;
using Infrastructure.Adapters.Repositories;
using Tests.Utils;

namespace Tests.UnitTests;

public class RentalUnitTests
{
    [Fact]
    public async Task RentalUnavailable()
    {         
        await using var context = InMemoryDbContextFactory.Create();

        var rentals = new List<Rental>
        {
            new() { Id = 1, CarId = 1, WithdrawalDate = DateTime.Now.AddDays(-1), DevolutionDate = DateTime.Now.AddDays(1) },
            new() { Id = 2, CarId = 1, WithdrawalDate = DateTime.Now.AddDays(-3), DevolutionDate = DateTime.Now.AddDays(-2) }
        };

        await context.Set<Rental>().AddRangeAsync(rentals);
        await context.SaveChangesAsync();

        var repository = new RentalRepository(context);

        var available = await repository.IsCarAvailableAsync(1, DateTime.Now, DateTime.Now.AddDays(2));

        Assert.False(available);
    }    

    [Fact]
    public async Task RentalAvailable()
    {
        await using var context = InMemoryDbContextFactory.Create();

        var rentals = new List<Rental>
        {
            new() { Id = 2, CarId = 1, WithdrawalDate = DateTime.Now.AddDays(-3), DevolutionDate = DateTime.Now.AddDays(-2) }
        };

        await context.Set<Rental>().AddRangeAsync(rentals);
        await context.SaveChangesAsync();

        var repository = new RentalRepository(context);

        var available = await repository.IsCarAvailableAsync(1, DateTime.Now, DateTime.Now.AddDays(2));

        Assert.True(available);
    }
}