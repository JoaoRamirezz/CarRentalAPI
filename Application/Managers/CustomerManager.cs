using Application.Interfaces;
using Application.Requests;
using Application.Services;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class CustomerManager : BaseManager<Customer, CustomerRequest, CustomerResponse, ICustomerRepository>, ICustomerManager
{
    public CustomerManager(ICustomerRepository repository) : base(repository)
    {
    }

    protected override Customer MapToEntity(CustomerRequest request)
    {
        var car = request.Adapt<Customer>();
        return car;
    }

    protected override CustomerResponse MapToResponse(Customer entity)
    {
        var response = entity.Adapt<CustomerResponse>();
        return response;
    }

    protected override void UpdateEntity(Customer entity, CustomerRequest request)
    {    
        request.Adapt(entity);
    }
}