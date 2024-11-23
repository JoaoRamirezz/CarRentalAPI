using Core.Domain.Entities;
using Core.Domain.Exceptions;

namespace Tests.UnitTests;

public class CustomerValidationTests
{
    [Fact]
    public void InvalidCpf()
    {
        var customer = new Customer
        {
            Cpf = "donathan"
        };

        Assert.Throws<InvalidCpfException>(() => customer.Validate());
    }

    [Fact]
    public void InvalidEmail()
    {
        var customer = new Customer
        {
            Cpf = "111.222.333-44",
            Email = "donathan"
        };

        Assert.Throws<InvalidEmailException>(() => customer.Validate());
    }

    [Fact]
    public void InvalidPhoneNumber()
    {
        var customer = new Customer
        {
            Cpf = "111.222.333-44",
            Email = "donathan@gmail.com",
            Name = "Donathan",
            PhoneNumber = "12345-1234",
        };

        Assert.Throws<InvalidPhoneNumber>(() => customer.Validate());
    }

    [Fact]
    public void InvalidEntity()
    {
        var customer = new Customer
        {
            Cpf = "111.222.333-44",
            Email = "donathan@gmail.com",
            PhoneNumber = "12 12345-1234",
        };

        Assert.Throws<InvalidEntityException>(() => customer.Validate());
    }

    [Fact]
    public void ValidEntity()
    {
        //// Create valid entity
        var customer = new Customer
        {
            Cpf = "111.222.333-44",
            Email = "donathan@gmail.com",
            Name = "Donathan",
            Address = "Rua dos Bobos, 0",
            PhoneNumber = "11 91234-5678",
        };

        customer.Validate();
    }
}