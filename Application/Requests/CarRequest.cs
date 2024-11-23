namespace Application.Requests;

public record CarRequest
{
    public int? CategoryId { get; set; }

    public string LicensePlate { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Manufacturer { get; set; } = null!;

    public int? Year { get; set; }
}