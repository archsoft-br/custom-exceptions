using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Broker;

[ExcludeFromCodeCoverage]
public class BrokerException : BadGatewayException
{
    public BrokerException()
    {
    }

    public BrokerException(string message) : base(message)
    {
    }

    public BrokerException(string message, Exception inner) : base(message, inner)
    {
    }
}

