using System.Text.RegularExpressions;
using Core.Domain.Exceptions;
using Core.Shared;

namespace Core.Domain.Entities;

public partial class Car : IEntity
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

    public void Validate()
    {
        if (!IsPlateValid()) 
        {
            throw DomainExceptions.InvalidPlate();
        }

        if (string.IsNullOrEmpty(this.Model) || string.IsNullOrEmpty(this.Manufacturer) || CategoryId == 0 || Year < 1900)
        {
            throw DomainExceptions.InvalidEntity("Invalid Car Entity");
        }
    }

    public bool IsPlateValid()
    {
        //// 3 letras - 4 digitos
        var platePattern = new Regex(@"^[aA-zZ]{3}-[0-9]{3}");
        return platePattern.IsMatch(this.LicensePlate);
    }
}
