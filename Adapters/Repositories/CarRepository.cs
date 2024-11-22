namespace Adapters.Repositories;

using Adapters.Models;
using Core.Domain.Entities;

public class CarRepository : BaseRepository<Car>
{
    public CarRepository(CarRentalDbContext context) : base(context)
    {
    }
}