using Core.Shared;

namespace Core.Domain.Entities;

public partial class Payment : IEntity
{
    public int Id { get; set; }

    public int RentalId { get; set; }

    public DateTime Date { get; set; }

    public decimal? Value { get; set; }

    public string Method { get; set; }

    public string Status { get; set; }

    public virtual Rental Rental { get; set; } = null!;

    public void Validate()
    {
    }
}
