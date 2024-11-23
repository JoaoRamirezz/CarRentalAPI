using System.Text.RegularExpressions;
using Core.Domain.Exceptions;
using Core.Shared;

namespace Core.Domain.Entities;

public partial class Customer : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public void Validate()
    {
        if (!IsCpfValid())
        {
            throw DomainExceptions.InvalidCpf();
        }

        if (!IsValidEmail())
        {
            throw DomainExceptions.InvalidEmail();
        }

        if (!ValidPhoneNumber())
        {
            throw DomainExceptions.InvalidPhoneNumber();
        }

        if (string.IsNullOrEmpty(this.Name) || string.IsNullOrEmpty(this.Address))
        {
            throw DomainExceptions.InvalidEntity("Invalid Customer Entity");
        }
    }

    public bool IsCpfValid()
    {
        var cpfPattern = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        return cpfPattern.IsMatch(this.Cpf);
    }

    public bool IsValidEmail()
    {
        var emailPattern = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        return emailPattern.IsMatch(this.Email);
    }

    public bool ValidPhoneNumber()
    {
        var phonePattern = new Regex(@"^\d{2} \d{5}-\d{4}$");
        return phonePattern.IsMatch(this.PhoneNumber);
    }
}
