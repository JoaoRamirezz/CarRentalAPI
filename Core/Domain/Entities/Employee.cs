using Core.Shared;

namespace Core.Domain.Entities;

public partial class Employee : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string PhoneNumber { get; set; }

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

    public void Validate()
    {
    }
}
