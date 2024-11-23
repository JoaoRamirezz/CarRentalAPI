using Core.Shared;

namespace Core.Domain.Entities;

public partial class Category : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public void Validate()
    {
    }
}
