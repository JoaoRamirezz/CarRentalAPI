namespace Core.Domain.Exceptions;

public static class DomainExceptions 
{
    public static EntityNotFoundException EntityNotFound(int id) => new EntityNotFoundException($"Entity with id {id} not found");

    public static EntityAlreadyExistsException EntityAlreadyExists(int id) => new EntityAlreadyExistsException($"Entity with id {id} already exists");

    public static InvalidEntityException InvalidEntity(string message) => new InvalidEntityException(message);

    public static InvalidEntityStateException InvalidEntityState(string message) => new InvalidEntityStateException(message);
}

public class DomainException(string message) : Exception(message);

public class EntityNotFoundException(string message) : DomainException(message);

public class EntityAlreadyExistsException(string message) : DomainException(message);

public class InvalidEntityException(string message) : DomainException(message);

public class InvalidEntityStateException(string message) : DomainException(message);
