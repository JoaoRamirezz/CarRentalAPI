using Application.Interfaces;
using Application.Managers;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : BaseAPIController<ICustomerManager, CustomerRequest, CustomerResponse>
{
    public CustomerController(ICustomerManager manager) : base(manager)
    {
    }   
}