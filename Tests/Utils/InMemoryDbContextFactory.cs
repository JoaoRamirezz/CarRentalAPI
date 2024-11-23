using Infrastrucute.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Tests.Utils;

public static class InMemoryDbContextFactory
{
    public static CarRentalDbContext Create()
    {
        var options = new DbContextOptionsBuilder<CarRentalDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        return new CarRentalDbContext(options);
    }
}