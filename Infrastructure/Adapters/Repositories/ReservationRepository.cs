namespace Infrastructure.Adapters.Repositories;

using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;

public class ReservationRepository : BaseRepository<Reservation, CarRentalDbContext>, IReservationRepository
{
    public ReservationRepository(CarRentalDbContext context) : base(context)
    {
    }
}