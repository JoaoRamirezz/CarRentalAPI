namespace Infrastructure.Adapters.Repositories;

using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;

public class CustomerRepository : BaseRepository<Customer, CarRentalDbContext>, ICustomerRepository
{
    public CustomerRepository(CarRentalDbContext context) : base(context)
    {
    }
}