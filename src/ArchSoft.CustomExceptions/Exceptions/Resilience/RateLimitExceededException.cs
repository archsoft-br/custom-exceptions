using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Resilience;

[ExcludeFromCodeCoverage]
public class RateLimitExceededException : TooManyRequestsException
{
    public RateLimitExceededException()
    {
    }

    public RateLimitExceededException(string message)
        : base(message)
    {
    }

    public RateLimitExceededException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
