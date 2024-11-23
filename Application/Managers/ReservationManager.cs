using Application.Interfaces;
using Application.Requests;
using Application.Services;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class ReservationManager : BaseManager<Reservation, ReservationRequest, ReservationResponse, IReservationRepository>, IReservationManager
{
    public ReservationManager(IReservationRepository repository) : base(repository)
    {
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