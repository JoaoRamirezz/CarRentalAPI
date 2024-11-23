namespace Application.Requests;

public record EmployeeRequest
{
    public string Name { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string PhoneNumber { get; set; }
}