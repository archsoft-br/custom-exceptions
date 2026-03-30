using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Integration;

[ExcludeFromCodeCoverage]
public class IntegrationException : BadGatewayException
{
    public IntegrationException()
    {
    }

    public IntegrationException(string message) : base(message)
    {
    }

    public IntegrationException(string message, Exception inner) : base(message, inner)
    {
    }
}

