using Application.Requests;

namespace Application.Interfaces;

public interface IPaymentManager : IManager<PaymentRequest, PaymentResponse>
{    
}