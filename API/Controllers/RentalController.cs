using Application.Interfaces;
using Application.Managers;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RentalController : BaseAPIController<IRentalManager, RentalRequest, RentalResponse>
{
    public RentalController(IRentalManager manager) : base(manager)
    {
    }   
}