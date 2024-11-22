namespace Infrastructure.Adapters.Repositories;

using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;

public class RentalRepository : BaseRepository<Rental, CarRentalDbContext>, IRentalRepository
{
    public RentalRepository(CarRentalDbContext context) : base(context)
    {
    }
}