using Adapters.Models;
using Application.Interfaces;

namespace Adapters.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}