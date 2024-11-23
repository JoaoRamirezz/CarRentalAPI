using Application.Requests;

namespace Application.Interfaces;

public interface IEmployeeManager : IManager<EmployeeRequest, EmployeeResponse>
{    
}