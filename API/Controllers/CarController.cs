using Application.Interfaces;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarController : BaseAPIController<ICarManager, CarRequest, CarResponse>
{
    public CarController(ICarManager manager) : base(manager)
    {
    }   
}