using Application.Interfaces;
using Application.Requests;
using Application.Services;
using Core.Domain.Entities;
using Core.Domain.Interfaces;

namespace Application.Managers;

public class CategoryManager : BaseManager<Category, CategoryRequest, CategoryResponse>, ICategoryManager
{
    public CategoryManager(ICategoryRepository repository) : base(repository)
    {
    }

    protected override Category MapToEntity(CategoryRequest request)
    {
        return new Category
        {
            Name = request.Name
        };
    }

    protected override CategoryResponse MapToResponse(Category entity)
    {
        return new CategoryResponse(entity.Id, entity.Name);
    }

    protected override void UpdateEntity(Category entity, CategoryRequest request)
    {
        entity.Name = request.Name;
    }
}