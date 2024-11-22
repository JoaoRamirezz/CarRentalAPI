namespace Adapters.Repositories;

using Adapters.Models;
using Core.Domain.Entities;
using Core.Domain.Interfaces;

public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(CarRentalDbContext context) : base(context)
    {
    }
}