namespace Infrastructure.Adapters.Repositories;

using System;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;
using Microsoft.EntityFrameworkCore;

public class ReservationRepository : BaseRepository<Reservation, CarRentalDbContext>, IReservationRepository
{
    public ReservationRepository(CarRentalDbContext context) : base(context)
    {
    }

    public async Task<bool> IsCarAvailableAsync(int carId, DateTime startDate, DateTime endDate)
    {
        var available = !await GetAll()
            .Where(r => r.CarId == carId)
            .AnyAsync(r => r.StartDate <= startDate && r.EndDate >= startDate || r.StartDate <= endDate && r.EndDate >= endDate);
        
        return available;
    }
}