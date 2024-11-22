namespace Infrastructure.Adapters.Repositories;

using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;

public class CategoryRepository : BaseRepository<Category, CarRentalDbContext>, ICategoryRepository
{
    public CategoryRepository(CarRentalDbContext context) : base(context)
    {
    }
}