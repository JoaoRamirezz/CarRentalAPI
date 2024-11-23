namespace Core.Domain.Interfaces;

using Core.Shared;
using Entities;

public interface IRentalRepository : IRepository<Rental>
{
    Task<bool> IsCarAvailableAsync(int carId, DateTime startDate, DateTime endDate);
}
