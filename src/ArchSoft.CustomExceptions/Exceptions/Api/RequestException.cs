using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Api;

[ExcludeFromCodeCoverage]
public class RequestException : BadRequestException
{
    public RequestException()
    {
    }

    public RequestException(string message) : base(message)
    {
    }

    public RequestException(string message, Exception inner) : base(message, inner)
    {
    }
}

