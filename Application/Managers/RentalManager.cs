using Application.Interfaces;
using Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Exceptions;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class RentalManager : BaseManager<Rental, RentalRequest, RentalResponse, IRentalRepository>, IRentalManager
{
    public RentalManager(IRentalRepository repository) : base(repository)
    {
    }

    public override Task<RentalResponse> CreateAsync(RentalRequest request)
    {
        return base.CreateAsync(request);
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