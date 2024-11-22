namespace Infrastructure.Adapters.Repositories;

using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;

public class PaymentRepository : BaseRepository<Payment, CarRentalDbContext>, IPaymentRepository
{
    public PaymentRepository(CarRentalDbContext context) : base(context)
    {
    }
}