namespace Application.Requests;

public record PaymentRequest
{
    public int RentalId { get; set; }

    public DateTime Date { get; set; }

    public decimal? Value { get; set; }

    public string Method { get; set; }

    public string Status { get; set; }
}