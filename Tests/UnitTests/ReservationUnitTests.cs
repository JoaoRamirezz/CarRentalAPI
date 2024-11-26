using Core.Domain.Entities;
using Infrastructure.Adapters.Repositories;
using Tests.Utils;

namespace Tests.UnitTests;

public class ReservationUnitTests
{
    [Fact]
    public async Task ReservatioUnavailable()
    {         
        await using var context = InMemoryDbContextFactory.Create();

        var reservations = new List<Reservation>
        {
            new() { Id = 1, CarId = 1, StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now.AddDays(1) },
            new() { Id = 2, CarId = 1, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(-2) }
        };

        await context.Set<Reservation>().AddRangeAsync(reservations);
        await context.SaveChangesAsync();

        var repository = new ReservationRepository(context);

        var available = await repository.IsCarAvailableAsync(1, DateTime.Now, DateTime.Now.AddDays(2));

        Assert.False(available);
    }    

    [Fact]
    public async Task ReservationAvailable()
    {
        await using var context = InMemoryDbContextFactory.Create();

        var reservations = new List<Reservation>
        {
            new() { Id = 2, CarId = 1, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(-2) }
        };

        await context.Set<Reservation>().AddRangeAsync(reservations);
        await context.SaveChangesAsync();

        var repository = new ReservationRepository(context);

        var available = await repository.IsCarAvailableAsync(1, DateTime.Now, DateTime.Now.AddDays(2));

        Assert.True(available);
    }
}