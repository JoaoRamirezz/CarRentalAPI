using Application.Interfaces;
using Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class EmployeeManager : BaseManager<Employee, EmployeeRequest, EmployeeResponse, IEmployeeRepository>, IEmployeeManager
{
    public EmployeeManager(IEmployeeRepository repository) : base(repository)
    {
    }

    protected override Employee MapToEntity(EmployeeRequest request)
    {
        var employee = request.Adapt<Employee>();
        return employee;
    }

    protected override EmployeeResponse MapToResponse(Employee entity)
    {
        var response = entity.Adapt<EmployeeResponse>();
        return response;
    }

    protected override void UpdateEntity(Employee entity, EmployeeRequest request)
    {    
        request.Adapt(entity);
    }
}