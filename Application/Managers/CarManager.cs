using Application.Interfaces;
using Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class CarManager : BaseManager<Car, CarRequest, CarResponse, ICarRepository>, ICarManager
{
    public CarManager(ICarRepository repository) : base(repository)
    {
    }

    protected override Car MapToEntity(CarRequest request)
    {
        var car = request.Adapt<Car>();
        return car;
    }

    protected override CarResponse MapToResponse(Car entity)
    {
        var response = entity.Adapt<CarResponse>();
        return response;
    }

    protected override void UpdateEntity(Car entity, CarRequest request)
    {    
        request.Adapt(entity);
    }
}