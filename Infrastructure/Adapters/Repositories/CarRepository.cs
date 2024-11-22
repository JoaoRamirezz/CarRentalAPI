namespace Infrastructure.Adapters.Repositories;

using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;

public class CarRepository : BaseRepository<Car, CarRentalDbContext>, ICarRepository
{
    public CarRepository(CarRentalDbContext context) : base(context)
    {
    }
}