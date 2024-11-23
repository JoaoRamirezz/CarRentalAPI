using Application.Interfaces;
using Application.Requests;
using Application.Services;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class RentalManager : BaseManager<Rental, RentalRequest, RentalResponse>, IRentalManager
{
    public RentalManager(IRentalRepository repository) : base(repository)
    {
    }

    protected override Rental MapToEntity(RentalRequest request)
    {
        var rental = request.Adapt<Rental>();
        return rental;
    }

    protected override RentalResponse MapToResponse(Rental entity)
    {
        var response = entity.Adapt<RentalResponse>();
        return response;
    }

    protected override void UpdateEntity(Rental entity, RentalRequest request)
    {    
        request.Adapt(entity);
    }
}