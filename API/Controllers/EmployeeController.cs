using Application.Interfaces;
using Application.Managers;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : BaseAPIController<IEmployeeManager, EmployeeRequest, EmployeeResponse>
{
    public EmployeeController(IEmployeeManager manager) : base(manager)
    {
    }   
}