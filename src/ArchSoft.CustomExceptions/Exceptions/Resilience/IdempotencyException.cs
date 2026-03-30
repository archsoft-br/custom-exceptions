using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Resilience;

[ExcludeFromCodeCoverage]
public class IdempotencyException : ConflictException
{
    public IdempotencyException()
    {
    }

    public IdempotencyException(string message)
        : base(message)
    {
    }

    public IdempotencyException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
