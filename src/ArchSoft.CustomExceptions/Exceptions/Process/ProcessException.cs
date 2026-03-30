using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Process;

[ExcludeFromCodeCoverage]
public class ProcessException : UnprocessableEntityException
{
    public ProcessException()
    {
    }

    public ProcessException(string message) : base(message)
    {
    }

    public ProcessException(string message, Exception inner) : base(message, inner)
    {
    }
}

