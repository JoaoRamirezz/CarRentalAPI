namespace Core.Domain.Interfaces;

using Core.Shared;
using Entities;

public interface IReservationRepository : IRepository<Reservation>
{
    Task<bool> IsCarAvailableAsync(int carId, DateTime startDate, DateTime endDate);
}
