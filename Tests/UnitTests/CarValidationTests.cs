using Core.Domain.Entities;
using Core.Domain.Exceptions;

namespace Tests;

public class CarValidationTests
{
    [Fact]
    public void InvalidPlate()
    {
        var car = new Car
        {
            LicensePlate = "DOMINIK"
        };

        Assert.Throws<InvalidPlateException>(() => car.Validate());
    }

    [Fact]
    public void InvalidEntity()
    {
        var car = new Car
        {
            LicensePlate = "ABC-1234",
            Year = 1885,
            CategoryId = 0,
            Model = string.Empty
            
        };

        Assert.Throws<InvalidEntityException>(() => car.Validate());
    }

    [Fact]
    public void ValidCar()
    {
        var car = new Car
        {
            LicensePlate = "ABC-1234",
            Year = 2020,
            CategoryId = 1,
            Model = "Model",
            Manufacturer = "Manufacturer"
        };

        car.Validate();
    }
}