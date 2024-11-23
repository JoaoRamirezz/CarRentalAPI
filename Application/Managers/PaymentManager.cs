using Application.Interfaces;
using Application.Requests;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Mapster;

namespace Application.Managers;

public class PaymentManager : BaseManager<Payment, PaymentRequest, PaymentResponse, IPaymentRepository>, IPaymentManager
{
    public PaymentManager(IPaymentRepository repository) : base(repository)
    {
    }

    protected override Payment MapToEntity(PaymentRequest request)
    {
        var payment = request.Adapt<Payment>();
        return payment;
    }

    protected override PaymentResponse MapToResponse(Payment entity)
    {
        var response = entity.Adapt<PaymentResponse>();
        return response;
    }

    protected override void UpdateEntity(Payment entity, PaymentRequest request)
    {    
        request.Adapt(entity);
    }
}