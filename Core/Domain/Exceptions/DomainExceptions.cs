namespace Core.Domain.Exceptions;

public class DomainException(string message) : Exception(message);

public class EntityNotFoundException(string message) : DomainException(message);

public class EntityAlreadyExistsException(string message) : DomainException(message);

public class InvalidEntityException(string message) : DomainException(message);

public class InvalidEntityStateException(string message) : DomainException(message);
