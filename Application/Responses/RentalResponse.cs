namespace Application.Requests;

public record RentalResponse
{
    public int Id { get; set; }

    public int ReservationId { get; set; }

    public int CustomerId { get; set; }

    public int CarId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime WithdrawalDate { get; set; }

    public DateTime DevolutionDate { get; set; }

    public decimal TotalValue { get; set; }

    public string Status { get; set; } = null!;
}