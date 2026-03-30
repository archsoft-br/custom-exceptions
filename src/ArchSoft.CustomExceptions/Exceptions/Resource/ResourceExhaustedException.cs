using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Resource;

[ExcludeFromCodeCoverage]
public class ResourceExhaustedException : TooManyRequestsException
{
    public ResourceExhaustedException()
    {
    }

    public ResourceExhaustedException(string message)
        : base(message)
    {
    }

    public ResourceExhaustedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
