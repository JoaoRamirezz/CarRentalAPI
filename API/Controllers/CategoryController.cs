using Application.Interfaces;
using Application.Requests;
using Core.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryManager _categoryManager;

    public CategoryController(ICategoryManager manager)
    {
        _categoryManager = manager;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryResponse>>> Get()
    {
        var categories = await _categoryManager.GetAllAsync();
        return Ok(categories);
    }

    [HttpPost]
    public async Task<ActionResult<CategoryResponse>> Post(CategoryRequest request)
    {
        var category = await _categoryManager.CreateAsync(request);
        return Ok(category);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CategoryResponse>> Get(int id)
    {
        try
        {
            var category = await _categoryManager.GetByIdAsync(id);
            return Ok(category);
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<CategoryResponse>> Patch(int id, CategoryRequest request)
    {
        try
        {
            var category = await _categoryManager.UpdateAsync(id, request);
            return Ok(category);
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
            await _categoryManager.DeleteAsync(id);
            return NoContent();
        }
        catch (EntityNotFoundException)
        {
            return NotFound();
        }
    }
}