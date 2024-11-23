using Application.Requests;

namespace Application.Interfaces;

public interface ICustomerManager : IManager<CustomerRequest, CustomerResponse>
{    
}