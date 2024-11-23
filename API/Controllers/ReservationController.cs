using Application.Interfaces;
using Application.Managers;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : BaseAPIController<IReservationManager, ReservationRequest, ReservationResponse>
{
    public ReservationController(IReservationManager manager) : base(manager)
    {
    }   
}