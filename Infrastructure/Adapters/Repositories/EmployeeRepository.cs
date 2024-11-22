namespace Infrastructure.Adapters.Repositories;

using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;

public class EmployeeRepository : BaseRepository<Employee, CarRentalDbContext>, IEmployeeRepository
{
    public EmployeeRepository(CarRentalDbContext context) : base(context)
    {
    }
}