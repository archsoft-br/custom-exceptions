using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Broker;

[ExcludeFromCodeCoverage]
public class ConsumerException : BadGatewayException
{
    public ConsumerException()
    {
    }

    public ConsumerException(string message) : base(message)
    {
    }

    public ConsumerException(string message, Exception inner) : base(message, inner)
    {
    }
}

