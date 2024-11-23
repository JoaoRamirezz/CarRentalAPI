using Application.Interfaces;
using Core.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public abstract class BaseAPIController<TManager, TRequest, TResponse> : ControllerBase
    where TManager : IManager<TRequest, TResponse>
{
    protected readonly TManager manager;

    protected BaseAPIController(TManager manager)
    {
        this.manager = manager;
    }

    [HttpGet]
    public virtual async Task<IEnumerable<TResponse>> GetAll()
    {
        var entities = await manager.GetAllAsync();
        return entities;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TResponse>> GetById(int id)
    {
        try
        {
            var entity = await manager.GetByIdAsync(id);
            return Ok(entity);
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] TRequest request)
    {
        var result = await manager.CreateAsync(request);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TResponse>> Put(int id, TRequest request)
    {
        try
        {
            var entity = await manager.UpdateAsync(id, request);
            return Ok(entity);
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            var deleted = await manager.DeleteAsync(id);
            return Ok(deleted);
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }
    }
}
