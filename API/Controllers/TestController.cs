using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;

    private readonly ICategoryRepository _categoryRepository;

    public TestController(IEmployeeRepository employeeRepository, ICategoryRepository categoryRepository)
    {
        _employeeRepository = employeeRepository;
        _categoryRepository = categoryRepository;
}

    [HttpGet]
    public IQueryable<Category> GetAll()
    {
        return _categoryRepository.GetAll();
    }

    [HttpPost]
    public async Task<IActionResult> AddCategory([FromBody] string name)
    {
        var created = await _categoryRepository.Add(new Category { Name = name });

        await this._categoryRepository.SaveChangesAsync();

        return Ok(created);
    }
}