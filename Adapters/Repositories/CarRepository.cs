using Adapters.Models;
using Domain.Models;

namespace Adapters.Repositories
{
    public class CarRepository : BaseRepository<Car>
    {
        public CarRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}