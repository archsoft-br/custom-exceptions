using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Concurrency;

[ExcludeFromCodeCoverage]
public class VersionMismatchException : ConflictException
{
    public VersionMismatchException()
    {
    }

    public VersionMismatchException(string message)
        : base(message)
    {
    }

    public VersionMismatchException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
