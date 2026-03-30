using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Resilience;

[ExcludeFromCodeCoverage]
public class ThrottlingException : TooManyRequestsException
{
    public ThrottlingException()
    {
    }

    public ThrottlingException(string message)
        : base(message)
    {
    }

    public ThrottlingException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
