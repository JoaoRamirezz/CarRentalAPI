using Application.Interfaces;
using Application.Managers;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : BaseAPIController<IPaymentManager, PaymentRequest, PaymentResponse>
{
    public PaymentController(IPaymentManager manager) : base(manager)
    {
    }   
}