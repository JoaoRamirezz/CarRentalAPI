using Application.Interfaces;
using Core.Domain.Exceptions;
using Core.Shared;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public abstract class BaseManager<TEntity, TRequest, TResponse> : IManager<TRequest, TResponse>
    where TEntity : class, new()
{
    protected readonly IRepository<TEntity> _repository;

    public BaseManager(IRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public async Task<TResponse> CreateAsync(TRequest request)
    {
        var entity = MapToEntity(request);

        await _repository.Add(entity);

        await _repository.SaveChangesAsync();

        return MapToResponse(entity);
    }

    public async Task<IEnumerable<TResponse>> GetAllAsync()
    {
        var entities = await _repository.GetAll().ToListAsync();

        return entities.Select(MapToResponse);
    }

    public async Task<TResponse> GetByIdAsync(int id)
    {
        var entity = await _repository.GetById(id) ?? throw DomainExceptions.EntityNotFound(id);

        return MapToResponse(entity);
    }

    public async Task<TResponse> UpdateAsync(int id, TRequest request)
    {
        var entity = await _repository.GetById(id) ?? throw DomainExceptions.EntityNotFound(id);

        UpdateEntity(entity, request);

        await _repository.Update(entity);

        await _repository.SaveChangesAsync();

        return MapToResponse(entity);
    }

    public async Task<TResponse> DeleteAsync(int id)
    {
        var entity = await _repository.GetById(id) ?? throw DomainExceptions.EntityNotFound(id);

        await _repository.Delete(id);

        await _repository.SaveChangesAsync();

        return MapToResponse(entity);
    }

    protected abstract TResponse MapToResponse(TEntity entity);

    protected abstract TEntity MapToEntity(TRequest request);

    protected abstract void UpdateEntity(TEntity entity, TRequest request);

}