using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Operation;

[ExcludeFromCodeCoverage]
public class OperationException : ConflictException
{
    public OperationException()
    {
    }

    public OperationException(string message) : base(message)
    {
    }

    public OperationException(string message, Exception inner) : base(message, inner)
    {
    }
}

