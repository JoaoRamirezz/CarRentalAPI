using Application.Interfaces;
using Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Exceptions;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class ReservationManager : BaseManager<Reservation, ReservationRequest, ReservationResponse, IReservationRepository>, IReservationManager
{
    public ReservationManager(IReservationRepository repository) : base(repository)
    {
    }

    public override async Task<ReservationResponse> CreateAsync(ReservationRequest request)
    {
        var available = await  _repository.IsCarAvailableAsync(request.CarId, request.StartDate, request.EndDate);

        if (!available)
        {
            throw DomainExceptions.CarAlreadyReserved();
        }

        return await base.CreateAsync(request);
    }

    protected override Reservation MapToEntity(ReservationRequest request)
    {
        var obj = request.Adapt<Reservation>();
        return obj;
    }

    protected override ReservationResponse MapToResponse(Reservation entity)
    {
        var response = entity.Adapt<ReservationResponse>();
        return response;
    }

    protected override void UpdateEntity(Reservation entity, ReservationRequest request)
    {    
        request.Adapt(entity);
    }
}