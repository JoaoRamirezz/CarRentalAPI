﻿using Core.Shared;

namespace Core.Domain.Entities;

public partial class Reservation : IEntity
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int CarId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

    public void Validate()
    {
    }
}
