namespace Core.Domain.Exceptions;

public static class DomainExceptions 
{
    public static EntityNotFoundException EntityNotFound(int id) => new($"Entity with id {id} not found");

    public static EntityAlreadyExistsException EntityAlreadyExists(int id) => new($"Entity with id {id} already exists");

    public static InvalidEntityException InvalidEntity(string message) => new(message);

    public static InvalidEntityStateException InvalidEntityState(string message) => new(message);

    public static InvalidPlateException InvalidPlate() => new("License Plate out of format: AAA-0000");
}

public class DomainException(string message) : Exception(message);

public class EntityNotFoundException(string message) : DomainException(message);

public class EntityAlreadyExistsException(string message) : DomainException(message);

public class InvalidEntityException(string message) : DomainException(message);

public class InvalidEntityStateException(string message) : DomainException(message);

public class InvalidPlateException(string message) : DomainException(message);