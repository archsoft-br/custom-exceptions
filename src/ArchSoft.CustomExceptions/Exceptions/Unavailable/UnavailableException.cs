using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Unavailable;

[ExcludeFromCodeCoverage]
public class UnavailableException : ServiceUnavailableException
{
    public UnavailableException()
    {
    }

    public UnavailableException(string message)
        : base(message)
    {
    }

    public UnavailableException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

