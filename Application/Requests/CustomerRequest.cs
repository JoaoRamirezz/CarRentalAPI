namespace Application.Requests;

public record CustomerRequest
{
    public string Name { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;
}