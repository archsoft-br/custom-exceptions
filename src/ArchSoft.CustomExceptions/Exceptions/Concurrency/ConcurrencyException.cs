using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Concurrency;

[ExcludeFromCodeCoverage]
public class ConcurrencyException : ConflictException
{
    public ConcurrencyException()
    {
    }

    public ConcurrencyException(string message)
        : base(message)
    {
    }

    public ConcurrencyException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
