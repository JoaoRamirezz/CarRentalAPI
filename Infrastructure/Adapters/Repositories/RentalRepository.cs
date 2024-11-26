namespace Infrastructure.Adapters.Repositories;

using System;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Core.Shared;
using Infrastrucute.Persistance;
using Microsoft.EntityFrameworkCore;

public class RentalRepository : BaseRepository<Rental, CarRentalDbContext>, IRentalRepository
{
    public RentalRepository(CarRentalDbContext context) : base(context)
    {
    }
}