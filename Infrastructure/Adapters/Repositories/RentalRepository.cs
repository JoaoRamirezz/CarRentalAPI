namespace Infrastructure.Adapters.Repositories;

using System;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;
using Microsoft.EntityFrameworkCore;

public class RentalRepository : BaseRepository<Rental, CarRentalDbContext>, IRentalRepository
{
    public RentalRepository(CarRentalDbContext context) : base(context)
    {
    }

    public async Task<bool> IsCarAvailableAsync(int carId, DateTime startDate, DateTime endDate)
    {
          var available = !await GetAll()
            .Include(r => r.Car)
            .Where(r => r.CarId == carId)
            .AnyAsync(r => r.WithdrawalDate <= startDate && r.DevolutionDate >= startDate || r.WithdrawalDate <= endDate && r.DevolutionDate >= endDate);
        
        return available;
    }
}