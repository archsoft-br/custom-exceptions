using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Broker;

[ExcludeFromCodeCoverage]
public class ProducerException : BadGatewayException
{
    public ProducerException()
    {
    }

    public ProducerException(string message) : base(message)
    {
    }

    public ProducerException(string message, Exception inner) : base(message, inner)
    {
    }
}

