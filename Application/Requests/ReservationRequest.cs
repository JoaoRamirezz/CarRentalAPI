namespace Application.Requests;

public record ReservationRequest
{
    public int ClientId { get; set; }

    public int CarId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Status { get; set; } = null!;
}