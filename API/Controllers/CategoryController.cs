using Application.Interfaces;
using Application.Managers;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : BaseAPIController<ICategoryManager, CategoryRequest, CategoryResponse>
{
    public CategoryController(ICategoryManager manager) : base(manager)
    {
    }   
}