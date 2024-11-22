namespace Core.Domain.Entities;
public partial class Rental
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

    public virtual Car Car { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Reservation Reservation { get; set; } = null!;
}
