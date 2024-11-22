namespace Core.Domain.Entities;

public partial class Car
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string LicensePlate { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Manufacturer { get; set; } = null!;

    public int Year { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
